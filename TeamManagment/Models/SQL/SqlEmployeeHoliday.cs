using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlEmployeeHoliday : IEmployeeHoliday
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlEmployeeHoliday(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }
        public void AddEmployeeHoliday(EmployeeHoliday item)
        {
            cnt.EmployeeHolidays.Add(item);
            cnt.SaveChanges();
        }

        public void DeleteEmployeeHoliday(EmployeeHoliday item)
        {
            cnt.EmployeeHolidays.Remove(item);
            cnt.SaveChanges();
        }

        public IQueryable<EmployeeHoliday> GetAllEmployeeHolidays()
        {
            return cnt.EmployeeHolidays.Include(c => c.Employee);
        }
        public EmployeeHoliday GetEmployeeHoliday(int id)
        {
            return cnt.EmployeeHolidays.Include(c => c.Employee).FirstOrDefault(c => c.HolidayID == id);
        }

        public void UpdateEmployeeHoliday(EmployeeHoliday item)
        {
            EmployeeHoliday em = this.GetEmployeeHoliday(item.HolidayID);
            if (em != null)
            {
                em.DayDifference = item.DayDifference;
                em.EmployeeID = item.EmployeeID;
                em.FirstHolidayDay = item.FirstHolidayDay;
                em.HolidayReason = item.HolidayReason;
                em.HolidayState = item.HolidayState;
                em.LastHolidayDay = item.LastHolidayDay;

                cnt.EmployeeHolidays.Update(em);
            }
            cnt.SaveChanges();
        }
    }
}
