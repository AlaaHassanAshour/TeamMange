using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{
    public class SectionWork
    {
        [Key]
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public List<Jobs> Jobs{ get; set; }
    }
}
