using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{
    public class Jobs
    {
        [Key]
        public int JobID { get; set; }
        public string JobName { get; set; }
        public int SecID { get; set; }
        [ForeignKey("SecID")]
        public SectionWork Section { get; set; }
    }
}
