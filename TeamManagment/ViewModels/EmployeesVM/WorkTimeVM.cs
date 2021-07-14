using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels
{
    public class WorkTimeVM
    {
        public CompanyInfromation CompanyInfromation { get; set; }
        public WorkTime WorkTime { get; set; }
        public Employee Employee { get; set; }
    }
}
