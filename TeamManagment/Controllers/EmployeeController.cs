using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeamManagment.Models;
using TeamManagment.Models.Interfaces;
using TeamManagment.ViewModels;
using TeamManagment.ViewModels.AdminVM;
using TeamManagment.ViewModels.EmployeesVM;

namespace TeamManagment.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        public UserManager<IdentityUser> userManager;
        public SignInManager<IdentityUser> signInManager;
        public RoleManager<IdentityRole> roleManager;
        IEmployee ie;
        TeamMangmentContext cnt;
        ICompany ic;
        IEmployeeHoliday ieh;
        IExitPrmission iex;
        IWorkTime iw;
        public EmployeeController(UserManager<IdentityUser> userManager, IExitPrmission iex,
            SignInManager<IdentityUser> signInManager, IEmployee ie, TeamMangmentContext cnt,
            RoleManager<IdentityRole> roleManager, ICompany ic, IEmployeeHoliday ieh, IWorkTime iw)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.ie = ie;
            this.cnt = cnt;
            this.ic = ic;
            this.ieh = ieh;
            this.iex = iex;
            this.iw = iw;
        }
        public IActionResult Index()
        {
            MangmentStatistics emv = new MangmentStatistics();
            emv.Employees = ie.GetAllEmployees().ToList();
            emv.CompanyInfromation = ic.GetCompanyInfromation(1);
            emv.WorkTimes = iw.GetAllWorkTimes().Where(c => c.TheDate.Month == DateTime.Today.Month).ToList();
            emv.ExitePrmissions = iex.GetAllExitePrmissions().Where(c=>c.DayExit.Month==DateTime.Today.Month).ToList();
            emv.EmployeeHolidays=ieh.GetAllEmployeeHolidays().Where(c => c.LastHolidayDay.Month == DateTime.Today.Month && c.HolidayState==HolidayState.قيد_المراجعة).ToList();
            return View(emv);
        }
        public IActionResult Attendance()
        {
            EmployeeVM emv = new EmployeeVM();
            emv.Employees = ie.GetAllEmployees().ToList();
            emv.CompanyInfromation = ic.GetCompanyInfromation(1);
            return View(emv);
        }
        public IActionResult Employee(string EID)
        {
            EmployeeVM emp = new EmployeeVM();
            emp.CompanyInfromation = ic.GetCompanyInfromation(1);
            emp.Employee = ie.GetEmployee(EID);
            return View(emp);
        }
        public IActionResult AllEmployeeHoliday()
        {
            ViewBag.Employee = new SelectList(cnt.Employees, "EmployeeID", "FullName");
            ViewBag.Date = DateTime.Now;
            EmpHolidayVM lev = new EmpHolidayVM();
            lev.CompanyInfromation = ic.GetCompanyInfromation(1);
            lev.EmployeeHolidays = ieh.GetAllEmployeeHolidays().ToList();
            return View(lev);
        }
        public IActionResult AllEmployeeLeaves()
        {
            ViewBag.Employee = new SelectList(cnt.Employees, "EmployeeID", "FullName");
            ViewBag.Date = DateTime.Now;
            LeaveReaquestVM lev = new LeaveReaquestVM();
            lev.CompanyInfromation = ic.GetCompanyInfromation(1);
            lev.ExitePrmissions = iex.GetAllExitePrmissions().ToList();
            return View(lev);
        }
        public IActionResult EditState(int HID,HolidayState State)
        {
            EmployeeHoliday em = ieh.GetEmployeeHoliday(HID);
            em.HolidayState = State;
            ieh.UpdateEmployeeHoliday(em);
            return RedirectToAction("AllEmployeeHoliday");
        }
        public IActionResult AddEmployee()
        {
            EmployeeVM emp = new EmployeeVM();
            ViewBag.Section = new SelectList(cnt.SectionWorks, "SectionID", "SectionName");
            ViewBag.Jobs = new SelectList(cnt.Jobs, "JobID", "JobName");
            emp.Employees = ie.GetAllEmployees().ToList();
            emp.CompanyInfromation = ic.GetCompanyInfromation(1);
            return View(emp);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeVM emp)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser() {
                    UserName = emp.Employee.UserName,
                    Email=emp.Employee.EmailAddress,
                    PasswordHash = emp.Employee.Password
                };

                IdentityResult result = await userManager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Employee");
                    emp.Employee.EmployeeID = user.Id;
                    ie.AddEmployee(emp.Employee);
                    return RedirectToAction("AddEmployee");
                }
                foreach (IdentityError r in result.Errors)
                {
                    ModelState.AddModelError("", " هناك خطأ في أحد الحقول تأكد أنك عبأت جميع الحقول أو انك أضفت بيانات صحيحة  ");
                }
            }
                return RedirectToAction("AddEmployee");
        }
        public IActionResult EditEmployee(string EID)
        {
            ViewBag.Section = new SelectList(cnt.SectionWorks, "SectionID", "SectionName");
            ViewBag.Jobs = new SelectList(cnt.Jobs, "JobID", "JobName");
            return View(ie.GetEmployee(EID));
        }
        [HttpPost]
        public IActionResult EditEmployee(Employee emp)
        {
            ie.UpdateEmployee(emp);
            return RedirectToAction("AddEmployee");
        }
        public async Task<IActionResult> DeletEmployee(string EID)
        {
            await userManager.DeleteAsync(await userManager.FindByIdAsync(EID));
            return RedirectToAction("AddEmployee");
        }
    }
}
