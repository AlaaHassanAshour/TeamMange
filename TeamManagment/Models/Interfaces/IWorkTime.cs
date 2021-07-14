using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface IWorkTime
    {
        public IQueryable<WorkTime> GetAllWorkTimes();
        public WorkTime GetWorkTime(int id);
        public void AddWorkTime(WorkTime item);
        public void UpdateWorkTime(WorkTime item);
        public void DeleteWorkTime(WorkTime item);
    }
}
