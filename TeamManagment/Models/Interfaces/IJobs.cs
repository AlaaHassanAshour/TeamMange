using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface IJobs
    {
        public IQueryable<Jobs> GetAllJobs();
        public Jobs GetJob(int id);
        public void AddJobs(Jobs item);
        public void UpdateJobs(Jobs item);
        public void DeleteJobs(Jobs item);
    }
}
