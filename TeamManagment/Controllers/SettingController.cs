using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeamManagment.Models;
using TeamManagment.Models.Interfaces;
using TeamManagment.ViewModels;

namespace TeamManagment.Controllers
{
    public class SettingController : Controller
    {
        ISection ise;
        IJobs ij;
        ICompany ic;
        TeamMangmentContext cnt;
        IHolidaySettings iho;
        IWebHostEnvironment ih;
        public SettingController(ISection ise, IJobs ij, TeamMangmentContext cnt,
            ICompany ic, IHolidaySettings iho, IWebHostEnvironment ih)
        {
            this.ij = ij;
            this.ise = ise;
            this.cnt = cnt;
            this.ic = ic;
            this.iho = iho;
            this.ih = ih;
        }
        public IActionResult AddHolidaySettings()
        {
            HolidaySettingVM hs = new HolidaySettingVM();
            hs.HolidaySettings= iho.GetAllHolidaySettings().ToList();
            hs.CompanyInfromation = ic.GetCompanyInfromation(1);
            return View(hs);
        }
        [HttpPost]
        public IActionResult AddHolidaySettings(HolidaySettingVM hol)
        {
            iho.AddHolidaySetting(hol.HolidaySetting);
            return RedirectToAction("AddHolidaySettings");
        }
        public IActionResult AddGeneralSetting()
        {
            CompanyInformationVM com = new CompanyInformationVM();
            com.CompanyInfromation = ic.GetCompanyInfromation(1);
            return View(com);
        }
        [HttpPost]
        public IActionResult AddGeneralSetting(CompanyInformationVM cm)
        {
            if (cm.CompanyInfromation.imagePath != null)
            {
                string imageName = Guid.NewGuid().ToString() + cm.CompanyInfromation.imagePath.FileName;
                string ImagePath = Path.Combine(ih.WebRootPath, "Images", imageName);
                FileStream fs = new FileStream(ImagePath, FileMode.Create);
                cm.CompanyInfromation.image = imageName;
                cm.CompanyInfromation.imagePath.CopyTo(fs);
            }
            ic.UpdateCompanyInfromation(cm.CompanyInfromation);
            return RedirectToAction("Index","Employee");
        }
        public IActionResult AddSection()
        {
            SectionVM sec = new SectionVM();
            sec.SectionWorks = ise.GetAllSectionWorks().ToList();
            sec.CompanyInfromation = ic.GetCompanyInfromation(1);
            return View(sec);
        }
        [HttpPost]
        public IActionResult AddSection(SectionVM sec)
        {
            ise.AddSectionWork(sec.SectionWork);
            return RedirectToAction("AddSection");
        }

        public IActionResult EditSection(int id)
        {
            return View(ise.GetSectionWork(id));
        }
        [HttpPost]
        public IActionResult EditSection(SectionWork sec)
        {
            ise.UpdateSectionWork(sec);
            return RedirectToAction("AddSection");
        }
        public IActionResult DeletSection(int id)
        {
            ise.DeleteSectionWork(ise.GetSectionWork(id));
            return RedirectToAction("AddSection");
        }
        public IActionResult AddJob()
        {
            SectionVM sec = new SectionVM();
            ViewBag.Section = new SelectList(cnt.SectionWorks, "SectionID", "SectionName");
            sec.Jobs = ij.GetAllJobs().ToList();
            sec.CompanyInfromation = ic.GetCompanyInfromation(1);
            return View(sec);
        }
        [HttpPost]
        public IActionResult AddJob(SectionVM sec)
        {
            ij.AddJobs(sec.Job);
            return RedirectToAction("AddJob");
        }
        public IActionResult EditJob(int id)
        {
            ViewBag.Section = new SelectList(cnt.SectionWorks, "SectionID", "SectionName");
            return View(ij.GetJob(id));
        }
        [HttpPost]
        public IActionResult EditJob(Jobs sec)
        {
            ij.UpdateJobs(sec);
            return RedirectToAction("AddJob");
        }
        public IActionResult DeletJob(int id)
        {
            ij.DeleteJobs(ij.GetJob(id));
            return RedirectToAction("AddJob");
        }
    }
}
