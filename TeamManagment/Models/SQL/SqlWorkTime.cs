using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlWorkTime : IWorkTime
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlWorkTime(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }
        public void AddWorkTime(WorkTime item)
        {
            cnt.WorkTimes.Add(item);
            cnt.SaveChanges();
        }
        public void DeleteWorkTime(WorkTime item)
        {
            cnt.WorkTimes.Remove(item);
            cnt.SaveChanges();
        }
        public IQueryable<WorkTime> GetAllWorkTimes()
        {
            return cnt.WorkTimes.Include(c => c.Employee)
                .Include(c => c.ExitePrmission);
        }

        public WorkTime GetWorkTime(int id)
        {
            return cnt.WorkTimes.Include(c => c.Employee)
                .Include(c => c.ExitePrmission).FirstOrDefault(c => c.WorkTimeID == id);
        }
        public void UpdateWorkTime(WorkTime item)
        {
            WorkTime ex = this.GetWorkTime(item.WorkTimeID);
            if (ex != null)
            {
                ex.EmployeeID = item.EmployeeID;
                ex.EmployeeTasks = item.EmployeeTasks;
                ex.ExtraHourDifference = item.ExtraHourDifference;
                ex.ExtraHourEnd = item.ExtraHourEnd;
                ex.ExtraHours = item.ExtraHours;
                ex.ExtraHourStart = item.ExtraHourStart;
                ex.TheDate = item.TheDate;
                ex.TheDay = item.TheDay;
                ex.ExiteID = item.ExiteID;
                ex.HolidayOrNot = item.HolidayOrNot;
                ex.HolidayID = item.HolidayID;
                ex.WorkDateDifference = item.WorkDateDifference;
                ex.WorkEnd = item.WorkEnd;
                ex.WorkStart = item.WorkStart;


                cnt.WorkTimes.Update(ex);
            }
            cnt.SaveChanges();
        }
    }
}
