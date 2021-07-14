using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels.EmployeesVM
{
    public class EmpHolidayVM
    {
        public CompanyInfromation CompanyInfromation { get; set; }
        public EmployeeHoliday EmployeeHoliday { get; set; }
        public List<EmployeeHoliday> EmployeeHolidays { get; set; }
    }
}
