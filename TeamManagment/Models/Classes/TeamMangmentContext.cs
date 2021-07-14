using Cronos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{

    public class AppDbContextFactory : IDesignTimeDbContextFactory<TeamMangmentContext>
    {
        public TeamMangmentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TeamMangmentContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Integrated Security=True;DataBase=TeamsDB;MultipleActiveResultSets=true");

            return new TeamMangmentContext(optionsBuilder.Options);
        }
    }
   
    public class TeamMangmentContext: IdentityDbContext
    {
        public TeamMangmentContext(DbContextOptions<TeamMangmentContext> op) : base(op)
        {
        }
        public DbSet<CompanyInfromation> CompanyInfromations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ExitePrmission> ExitePrmissions { get; set; }
        public DbSet<HolidaySetting> HolidaySettings { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<SectionWork> SectionWorks { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<EmployeeHoliday> EmployeeHolidays { get; set; }

    }
}
