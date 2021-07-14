using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface IEmployeeHoliday
    {
        public IQueryable<EmployeeHoliday> GetAllEmployeeHolidays();
        public EmployeeHoliday GetEmployeeHoliday(int id);
        public void AddEmployeeHoliday(EmployeeHoliday item);
        public void UpdateEmployeeHoliday(EmployeeHoliday item);
        public void DeleteEmployeeHoliday(EmployeeHoliday item);
    }
}
