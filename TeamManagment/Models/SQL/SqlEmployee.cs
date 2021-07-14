using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlEmployee : IEmployee
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlEmployee(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }
        public void AddEmployee(Employee item)
        {
            cnt.Employees.Add(item);
            cnt.SaveChanges();
        }
        public void DeleteEmployee(Employee item)
        {
            cnt.Employees.Remove(item);
            cnt.SaveChanges();
        }
        public IQueryable<Employee> GetAllEmployees()
        {
            return cnt.Employees.Include(c => c.WorkTimes).Include(c => c.Section)
                .Include(c => c.EmployeeHolidays).Include(c => c.Jobs)
                .Include(c => c.ExitePrmissions);
        }
        public Employee GetEmployee(string id)
        {
            return cnt.Employees.Include(c => c.WorkTimes).Include(c => c.Section)
                .Include(c => c.EmployeeHolidays).Include(c => c.Jobs)
                .Include(c => c.ExitePrmissions).FirstOrDefault(c => c.EmployeeID == id);
        }
        public void UpdateEmployee(Employee item)
        {
            Employee em = this.GetEmployee(item.EmployeeID);
            if (em != null)
            {
                em.EmailAddress = item.EmailAddress;
                em.Currency = item.Currency;
                em.FirstName = item.FirstName;
                em.LastName = item.LastName;
                em.Password = item.Password;
                em.PhoneNumber = item.PhoneNumber;
                em.Salary = item.Salary;
                em.SecoundName = item.SecoundName;
                em.UserName = item.UserName;
                em.workHours = item.workHours;

                cnt.Employees.Update(em);
            }
            cnt.SaveChanges();
        }
    }
}
