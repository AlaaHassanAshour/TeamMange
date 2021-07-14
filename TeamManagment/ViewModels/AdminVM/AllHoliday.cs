using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels
{
    public class AllHoliday
    {
        public CompanyInfromation CompanyInfromation { get; set; }
        public List<EmployeeHoliday> Holidays { get; set; }
        public EmployeeHoliday Holiday { get; set; }
    }
}
