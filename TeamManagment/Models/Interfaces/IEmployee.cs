using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface IEmployee
    {
        public IQueryable<Employee> GetAllEmployees();
        public Employee GetEmployee(string id);
        public void AddEmployee(Employee item);
        public void UpdateEmployee(Employee item);
        public void DeleteEmployee(Employee item);
    }
}
