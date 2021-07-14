using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models;

namespace TeamManagment.ViewModels
{
    public class SectionVM
    {
        public SectionWork SectionWork { get; set; }
        public List<SectionWork> SectionWorks { get; set; }
        public CompanyInfromation CompanyInfromation { get; set; }
        public Jobs Job { get; set; }
        public List<Jobs> Jobs { get; set; }
    }
}
