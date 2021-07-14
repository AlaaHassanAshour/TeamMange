using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels.AdminVM
{
    public class MangmentStatistics
    {
        public CompanyInfromation CompanyInfromation { get; set; }
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }
        public List<EmployeeHoliday> EmployeeHolidays { get; set; }
        public List<ExitePrmission> ExitePrmissions { get; set; }
        public List<WorkTime> WorkTimes { get; set; }
    }
}
