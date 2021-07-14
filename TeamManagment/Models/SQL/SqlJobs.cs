using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlJobs : IJobs
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlJobs(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }
        public void AddJobs(Jobs item)
        {
            cnt.Jobs.Add(item);
            cnt.SaveChanges();
        }
        public void DeleteJobs(Jobs item)
        {
            cnt.Jobs.Remove(item);
            cnt.SaveChanges();
        }
        public IQueryable<Jobs> GetAllJobs()
        {
            return cnt.Jobs.Include(c => c.Section);
        }
        public Jobs GetJob(int id)
        {
            return cnt.Jobs.Include(c => c.Section).FirstOrDefault(c => c.JobID == id);
        }
        public void UpdateJobs(Jobs item)
        {
            Jobs ex = this.GetJob(item.JobID);
            if (ex != null)
            {
                ex.JobName = item.JobName;
                ex.SecID = item.SecID;

                cnt.Jobs.Update(ex);
            }
            cnt.SaveChanges();
        }
    }
}
