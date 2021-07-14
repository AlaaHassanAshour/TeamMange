using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlHolidaySettings : IHolidaySettings
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        public SqlHolidaySettings(TeamMangmentContext cnt, UserManager<IdentityUser> userManager)
        {
            this.cnt = cnt;
            this.userManager = userManager;
        }
        public void AddHolidaySetting(HolidaySetting item)
        {
            cnt.HolidaySettings.Add(item);
            cnt.SaveChanges();
        }
        public void DeleteHolidaySetting(HolidaySetting item)
        {
            cnt.HolidaySettings.Remove(item);
            cnt.SaveChanges();
        }
        public IQueryable<HolidaySetting> GetAllHolidaySettings()
        {
            return cnt.HolidaySettings;
        }
        public HolidaySetting GetHolidaySetting(int id)
        {
            return cnt.HolidaySettings.FirstOrDefault(c => c.ID == id);

        }
        public void UpdateHolidaySetting(HolidaySetting item)
        {
            HolidaySetting ex = this.GetHolidaySetting(item.ID);
            if (ex != null)
            {
                ex.DayDifference = item.DayDifference;
                ex.FirstDay = item.FirstDay;
                ex.LastDay = item.LastDay;

                cnt.HolidaySettings.Update(ex);
            }
            cnt.SaveChanges();
        }
    }
    
}
