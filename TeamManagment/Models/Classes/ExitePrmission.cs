using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{
    public class ExitePrmission
    {
        [Key]
        public int ExitID { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime TimeBack { get; set; }
        public TimeSpan TotalHrs { get { return this.TimeBack - this.TimeOut; } }
        public DateTime DayExit { get; set; }
        public string ExitReason { get; set; }
        public string EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
       
    }
}
