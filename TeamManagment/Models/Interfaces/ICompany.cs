using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface ICompany
    {
        public IQueryable<CompanyInfromation> GetAllCompanyInfromations();
        public CompanyInfromation GetCompanyInfromation(int id);
        public void AddCompanyInfromation(CompanyInfromation item);
        public void UpdateCompanyInfromation(CompanyInfromation item);
        public void DeleteCompanyInfromation(CompanyInfromation item);
    }
}
