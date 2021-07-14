using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeamManagment.Models;
using TeamManagment.Models.Interfaces;
using TeamManagment.ViewModels;

namespace TeamManagment.Controllers
{
    public class WorkTimeController : Controller
    {
        ICompany ic;
        IWorkTime iw;
        IEmployee ie;
        public UserManager<IdentityUser> userManager;
        public SignInManager<IdentityUser> signInManager;
        public RoleManager<IdentityRole> roleManager;
        public WorkTimeController(ICompany ic, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, IEmployee ie,
            RoleManager<IdentityRole> roleManager, IWorkTime iw)
        {
            this.ic=ic;
            this.iw = iw;
            this.ie = ie;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        double totalWork = 0, totalHoliday = 0, totalExit = 0, totalAdd = 0;
        public IActionResult Index(string EID)
        {
            WorkTimeVM wvm = new WorkTimeVM();
            wvm.CompanyInfromation = ic.GetCompanyInfromation(1);
            wvm.Employee = ie.GetEmployee(userManager.GetUserId(User));
            totalWork = wvm.Employee.WorkTimes.Where(c => c.TheDate.Month == DateTime.Today.Month).Count();
            foreach (var item in wvm.Employee.ExitePrmissions.Where(c=>c.TimeOut.Month==DateTime.Today.Month)){
                totalExit += item.TotalHrs.TotalHours; }
            foreach (var item in wvm.Employee.EmployeeHolidays.Where(c=>c.HolidayState!=HolidayState.قيد_المراجعة && c.LastHolidayDay.Date==DateTime.Today.Date)) {
                totalHoliday += item.DayDifference;}
            foreach (var item in wvm.Employee.WorkTimes.Where(c => c.TheDate.Month == DateTime.Today.Month))
            {
                totalAdd += item.ExtraHourDifference;}
            ViewBag.totalWork = totalWork;
            ViewBag.totalExit = totalExit;
            ViewBag.totalHoliday = totalHoliday;
            ViewBag.totalAdd = totalAdd;
            wvm.WorkTime = iw.GetAllWorkTimes().FirstOrDefault(c => c.EmployeeID == EID && c.TheDate.Date==DateTime.Today.Date );
            return View(wvm);
        }
        public IActionResult AdNewWork()
        {
            WorkTime wt = new WorkTime()
            {
                EmployeeID = userManager.GetUserId(User),
                States = 1,
                TheDate = DateTime.Now,
                TheDay = DateTime.Now.DayOfWeek.ToString(),
            };
            iw.AddWorkTime(wt);
            return RedirectToAction("Index", "WorkTime", new { EID = wt.EmployeeID });
        }
        public IActionResult AddWork(int WID)
        {
            WorkTime wt= iw.GetWorkTime(WID);
            wt.States = 1;
            wt.WorkStart = DateTime.Now;
            iw.UpdateWorkTime(wt);
            return RedirectToAction("Index", "WorkTime", new { EID = wt.EmployeeID });
        }

        public IActionResult DoneWork(int WID)
        {
            WorkTime wt = iw.GetWorkTime(WID);
            wt.WorkEnd = DateTime.Now;
            wt.WorkEndDone = true;
            iw.UpdateWorkTime(wt);
            return RedirectToAction("Index", "WorkTime", new { EID = wt.EmployeeID });
        }

        public IActionResult AdditionalWork(int WID)
        {
            WorkTime wt = iw.GetWorkTime(WID);
            wt.ExtraHourStart = DateTime.Now;
            wt.ExtraHours = true;
            iw.UpdateWorkTime(wt);
            return RedirectToAction("Index", "WorkTime", new { EID = wt.EmployeeID });
        }

        public IActionResult AdditionalWorkDone(int WID)
        {
            WorkTime wt = iw.GetWorkTime(WID);
            wt.ExtraHourEnd = DateTime.Now;
            iw.UpdateWorkTime(wt);
            return RedirectToAction("Index", "WorkTime", new { EID = wt.EmployeeID });
        }

    }
}
