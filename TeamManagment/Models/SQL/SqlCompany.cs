using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlCompany : ICompany
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlCompany(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }

        public void AddCompanyInfromation(CompanyInfromation item)
        {
            cnt.CompanyInfromations.Add(item);
            cnt.SaveChanges();
        }
        public void DeleteCompanyInfromation(CompanyInfromation item)
        {
            cnt.CompanyInfromations.Remove(item);
            cnt.SaveChanges();
        }

        public IQueryable<CompanyInfromation> GetAllCompanyInfromations()
        {
            return cnt.CompanyInfromations;
        }

        public CompanyInfromation GetCompanyInfromation(int id)
        {
            return cnt.CompanyInfromations.FirstOrDefault(c => c.ID == id);
        }

        public void UpdateCompanyInfromation(CompanyInfromation item)
        {
            CompanyInfromation cm = this.GetCompanyInfromation(item.ID);
            if (cm != null)
            {
                cm.CompanyName = item.CompanyName;
                cm.WorkFirstDay = item.WorkFirstDay;
                cm.WorkLastDay = item.WorkLastDay;
                cm.image = item.image;
                cm.imagePath = item.imagePath;

                cnt.CompanyInfromations.Update(cm);
            }
            cnt.SaveChanges();
        }

    }
}
