using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels
{
    public class HolidaySettingVM
    {
        public CompanyInfromation CompanyInfromation { get; set; }
        public HolidaySetting HolidaySetting { get; set; }
        public List<HolidaySetting> HolidaySettings { get; set; }
    }
}
