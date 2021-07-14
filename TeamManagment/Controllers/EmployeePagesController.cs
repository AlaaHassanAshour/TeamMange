using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronos;
using Microsoft.AspNetCore.Mvc;
using TeamManagment.Models;
using TeamManagment.Models.Interfaces;
using TeamManagment.ViewModels.EmployeesVM;

namespace TeamManagment.Controllers
{
    public class EmployeePagesController : Controller
    {
        IExitPrmission iex;
        ICompany ic;
        TeamMangmentContext cnt;
        IEmployeeHoliday ieh;
        public EmployeePagesController(IExitPrmission iex, ICompany ic, TeamMangmentContext cnt,
            IEmployeeHoliday ieh)
        {
            this.iex = iex;
            this.ic = ic;
            this.cnt = cnt;
            this.ieh = ieh;
        }
       
        public IActionResult EmpHoliday()
        {
            ViewBag.Date = DateTime.Now;
            EmpHolidayVM lev = new EmpHolidayVM();
            lev.CompanyInfromation = ic.GetCompanyInfromation(1);
            lev.EmployeeHolidays = ieh.GetAllEmployeeHolidays().ToList();
            return View(lev);
        }

        [HttpPost]
        public IActionResult EmpHoliday(EmpHolidayVM lvm,string path)
        {
            ieh.AddEmployeeHoliday(lvm.EmployeeHoliday);
            if(path != null)
            {
                return RedirectToAction("AllEmployeeHoliday", "Employee");
            }
            return RedirectToAction("EmpHoliday");
        }
        public IActionResult LeaveReaquest()
        {
            ViewBag.Date = DateTime.Now;
            LeaveReaquestVM lev = new LeaveReaquestVM();
            lev.CompanyInfromation = ic.GetCompanyInfromation(1);
            lev.ExitePrmissions = iex.GetAllExitePrmissions().ToList();
            return View(lev);
        }
        [HttpPost]
        public IActionResult LeaveReaquest(LeaveReaquestVM lvm, string path)
        {
            lvm.ExitePrmission.DayExit = DateTime.Now;
            iex.AddExitePrmission(lvm.ExitePrmission);
            if (path != null)
            {
                return RedirectToAction("AllEmployeeLeaves", "Employee");
            }
            return RedirectToAction("LeaveReaquest");
        }
    }
}
