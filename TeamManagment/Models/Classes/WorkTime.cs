using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagment.Models
{
    public class WorkTime
    {
        [Key]
        public int WorkTimeID { get; set; }
        public int States { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public string WorkDateDifference { get { return (WorkEnd - WorkStart).TotalHours.ToString(); } set { } }
        public DateTime TheDate { get; set; }
        //public int Month { get; set; }
        public string TheDay { get; set; }
        public Boolean WorkEndDone { get; set; }
        public Boolean ExtraHours { get; set; }
        public DateTime ExtraHourStart { get; set; }
        public DateTime ExtraHourEnd { get; set; }
        public double ExtraHourDifference { get { return (ExtraHourEnd - ExtraHourStart).TotalHours; } set{ } }
        public string EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        public int? ExiteID { get; set; }
        [ForeignKey("ExiteID")]
        public ExitePrmission ExitePrmission { get; set; }
        public int? HolidayID { get; set; }
        [ForeignKey("HolidayID")]
        public EmployeeHoliday EmployeeHoliday { get; set; }
        public Boolean HolidayOrNot { get; set; }
        public string EmployeeTasks { get; set; }
    }
}
