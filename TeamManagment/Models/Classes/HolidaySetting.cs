using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{
    public class HolidaySetting
    {
        [Key]
        public int ID { get; set; }
        public string HolidayName { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
        public double DayDifference { get { return (LastDay - FirstDay).TotalDays; } set { } }
    }
}
