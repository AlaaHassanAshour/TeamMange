using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels.EmployeesVM
{
    public class LeaveReaquestVM
    {
        public CompanyInfromation CompanyInfromation { get; set; }
        public ExitePrmission ExitePrmission { get; set; }
        public List<ExitePrmission> ExitePrmissions { get; set; }
    }
}
