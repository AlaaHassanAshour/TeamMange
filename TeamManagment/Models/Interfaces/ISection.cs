using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface ISection
    {
        public IQueryable<SectionWork> GetAllSectionWorks();
        public SectionWork GetSectionWork(int id);
        public void AddSectionWork(SectionWork item);
        public void UpdateSectionWork(SectionWork item);
        public void DeleteSectionWork(SectionWork item);
    }
}
