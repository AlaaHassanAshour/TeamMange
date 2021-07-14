using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface IExitPrmission
    {
        public IQueryable<ExitePrmission> GetAllExitePrmissions();
        public ExitePrmission GetExitePrmission(int id);
        public void AddExitePrmission(ExitePrmission item);
        public void UpdateExitePrmission(ExitePrmission item);
        public void DeleteExitePrmission(ExitePrmission item);
    }
}
