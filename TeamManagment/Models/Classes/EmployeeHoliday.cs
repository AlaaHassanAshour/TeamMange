using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{
    public class EmployeeHoliday
    {
        [Key]
        public int HolidayID { get; set; }
        public DateTime FirstHolidayDay { get; set; }
        public DateTime LastHolidayDay { get; set; }
        public double DayDifference { get { return (LastHolidayDay - FirstHolidayDay).TotalDays; } set { } }
        public string HolidayReason { get; set; }
        public HolidayState HolidayState { get; set; }
        public string EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

    }
    public enum HolidayState
    {
        قيد_المراجعة , مقبول , مرفوض
    }
    public enum Type
    {
         اجازة , غياب
    }
}
