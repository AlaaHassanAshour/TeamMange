using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Models.Interfaces
{
    public interface IHolidaySettings
    {
        public IQueryable<HolidaySetting> GetAllHolidaySettings();
        public HolidaySetting GetHolidaySetting(int id);
        public void AddHolidaySetting(HolidaySetting item);
        public void UpdateHolidaySetting(HolidaySetting item);
        public void DeleteHolidaySetting(HolidaySetting item);
    }
}
