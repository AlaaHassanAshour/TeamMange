using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlSection : ISection
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlSection(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }
        public void AddSectionWork(SectionWork item)
        {
            cnt.SectionWorks.Add(item);
            cnt.SaveChanges();
        }
        public void DeleteSectionWork(SectionWork item)
        {
            cnt.SectionWorks.Remove(item);
            cnt.SaveChanges();
        }
        public IQueryable<SectionWork> GetAllSectionWorks()
        {
            return cnt.SectionWorks.Include(c => c.Jobs);
        }
        public SectionWork GetSectionWork(int id)
        {
            return cnt.SectionWorks.Include(c => c.Jobs).FirstOrDefault(c => c.SectionID == id);
        }
        public void UpdateSectionWork(SectionWork item)
        {
            SectionWork ex = this.GetSectionWork(item.SectionID);
            if (ex != null)
            {
                ex.SectionName = item.SectionName;

                cnt.SectionWorks.Update(ex);
            }
            cnt.SaveChanges();
        }
    }
}
