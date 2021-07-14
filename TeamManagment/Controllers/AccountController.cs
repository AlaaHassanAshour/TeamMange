using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using TeamManagment.Models;
using TeamManagment.Models.Interfaces;
using TeamManagment.ViewModels.UserVM;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amwaj.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<IdentityUser> userManager;
        public SignInManager<IdentityUser> signInManager;
        public RoleManager<IdentityRole> roleManager;
        public ILogger<AccountController> logger;
        IEmployee ie;
        IWebHostEnvironment ih;
        TeamMangmentContext db;
        public AccountController(UserManager<IdentityUser> userManager, TeamMangmentContext db,
            SignInManager<IdentityUser> signInManager, ILogger<AccountController> logger,
            RoleManager<IdentityRole> roleManager, IWebHostEnvironment ih, IEmployee ie)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.logger = logger;
            this.ie = ie;
            this.db = db;
        }

        [HttpPost]
        public async Task<IActionResult> LogOut(IdentityUser user)
        {
            if (user != null)
            {
                await signInManager.SignOutAsync();
                TempData["mesg"] = "Log Out Succeeded";
            }
            
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult LogIn(string ReturnUrl)
        {
            var gg = db.WorkTimes.ToList();
            ReturnUrl = ReturnUrl ?? Url.Content("~/");
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInVM log, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                if (log != null)
                {
                    var user = await userManager.FindByNameAsync(log.UserName);

                    var res = await signInManager.PasswordSignInAsync(log.UserName, log.Password, isPersistent: log.RememberMe, true);

                    if (res.Succeeded)
                    {
                        if (await userManager.IsInRoleAsync(user, "Admin"))
                            return RedirectToAction("Index", "Employee");

                        if (await userManager.IsInRoleAsync(user, "Employee"))
                            return RedirectToAction("Index", "WorkTime", new { EID = user.Id });

                    }
                    else
                    {
                        ModelState.AddModelError("",errorMessage: "هناك خطأ ما تأكد من بياناتك");
                    }

                }

            }
            return View();
        }


       

    }
}
