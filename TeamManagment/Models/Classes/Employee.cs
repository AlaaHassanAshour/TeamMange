using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{
    public class Employee
    {
        [Key]
        public String EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public IdentityUser User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecoundName { get; set; }
        public string FullName { get { return FirstName + " " + SecoundName +" " + LastName; } set { } }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int workHours { get; set; }
        public double Salary { get; set; }
        public Currency Currency { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int SecID { get; set; }
        [ForeignKey("SecID")]
        public SectionWork Section { get; set; }
        public int JID { get; set; }
        [ForeignKey("JID")]
        public Jobs Jobs { get; set; }
        public List<WorkTime> WorkTimes { get; set; }
        public List<ExitePrmission> ExitePrmissions { get; set; }
        public List<EmployeeHoliday> EmployeeHolidays { get; set; }
    }
    public enum Currency
    {
        شيكل,دولار
    }
}
