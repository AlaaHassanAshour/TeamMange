using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TeamManagment.Models;
using TeamManagment.Models.Interfaces;
using TeamManagment.Models.SQL;

namespace TeamManagment
{
    public class Startup
    {
        IEmployee ie;
        IWorkTime iw;
        IEmployeeHoliday ieh;
        IHolidaySettings ih;
        ICompany ic;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddHangfire(c =>
            c.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseDefaultTypeSerializer()
            .UseMemoryStorage()

            );
            services.AddHangfireServer();
            services.AddScoped<IEndingWork, SqlEndingWork>();
            services.AddScoped<IEmployee, SqlEmployee>();
            services.AddScoped<ICompany, SqlCompany>();
            services.AddScoped<IEmployeeHoliday, SqlEmployeeHoliday>();
            services.AddScoped<IExitPrmission, SqlExitPrmission>();
            services.AddScoped<IHolidaySettings, SqlHolidaySettings>();
            services.AddScoped<IJobs, SqlJobs>();
            services.AddScoped<ISection, SqlSection>();
            services.AddScoped<IWorkTime, SqlWorkTime>();
            services.AddScoped<SignInManager<IdentityUser>, SignInManager<IdentityUser>>();
            services.AddDbContext<TeamMangmentContext>(x => x.UseSqlServer(Configuration["Connection:ConnectionString"]));
            services.AddIdentity<IdentityUser, IdentityRole>(
               option =>
               {
                   option.Password.RequireDigit = false;
                   option.Password.RequiredLength = 4;
                   option.Password.RequireLowercase = false;
                   option.Password.RequireNonAlphanumeric = false;
                   option.Password.RequireUppercase = false;
                   option.User.RequireUniqueEmail = true;
                   option.User.AllowedUserNameCharacters = "ц г х й к л м н о п я р с т у ж ь з ш щ ч ъ А Ц Д  Е Ф М Л иадбеa b c d e f g h i j k l m n o p q r s t u v w x y z A B C D E F G H I J K L M N O P Q R S T U V W X Y Z 0 1 2 3 4 5 6 7 8 9 + _ - ";
               })
              .AddEntityFrameworkStores<TeamMangmentContext>()
              .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            IBackgroundJobClient backgroundJob, IRecurringJobManager recurringJobManager,
            IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });

            app.UseHangfireDashboard();
            //backgroundJob.Enqueue(() => Console.WriteLine("Hello HangFire Job !"));
            //recurringJobManager.AddOrUpdate(
            //    "Run evrey Minute", () =>
            //     serviceProvider.GetService<IEndingWork>().GetWorkDone(),
            //    "* * * * *"
            //   );

            //recurringJobManager.AddOrUpdate(
            //   "Run evrey Day", () =>
            //    serviceProvider.GetService<IEndingWork>().StartDate(),
            //   "59 11 * * *"
            //  );

            SqlEndingWork sql = new SqlEndingWork(ie,iw,ieh,ih,ic);
            RecurringJob.AddOrUpdate(() => sql.GetWorkDone(), "* * * * *");
            RecurringJob.AddOrUpdate(() => sql.StartDate(), "0 0 * * *");
        }
    }
}
