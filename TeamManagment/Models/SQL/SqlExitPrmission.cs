using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlExitPrmission : IExitPrmission
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlExitPrmission(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }
        public void AddExitePrmission(ExitePrmission item)
        {
            cnt.ExitePrmissions.Add(item);
            cnt.SaveChanges();
        }
        public void DeleteExitePrmission(ExitePrmission item)
        {
            cnt.ExitePrmissions.Remove(item);
            cnt.SaveChanges();
        }
        public IQueryable<ExitePrmission> GetAllExitePrmissions()
        {
            return cnt.ExitePrmissions.Include(c => c.Employee);
        }
        public ExitePrmission GetExitePrmission(int id)
        {
            return cnt.ExitePrmissions.Include(c => c.Employee).FirstOrDefault(c => c.ExitID == id);
        }
        public void UpdateExitePrmission(ExitePrmission item)
        {
            ExitePrmission ex = this.GetExitePrmission(item.ExitID);
            if (ex != null)
            {
                ex.DayExit = item.DayExit;
                ex.EmployeeID = item.EmployeeID;
                ex.ExitReason = item.ExitReason;
                ex.TimeBack = item.TimeBack;
                ex.TimeOut = item.TimeOut;

                cnt.ExitePrmissions.Update(ex);
            }
            cnt.SaveChanges();
        }
    }
}
