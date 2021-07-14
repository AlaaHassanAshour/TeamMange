using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models
{
    public class CompanyInfromation
    {
        [Key]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string image { get; set; }
        [NotMapped]
        public IFormFile imagePath { get; set; }
        public DayOfWeek WorkFirstDay { get; set; }
        public DayOfWeek WorkLastDay { get; set; }
    }
}
