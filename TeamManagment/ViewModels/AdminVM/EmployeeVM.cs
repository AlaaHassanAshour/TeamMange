using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels
{
    public class EmployeeVM
    {
        public CompanyInfromation CompanyInfromation { get; set; }
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }  
    }
}
