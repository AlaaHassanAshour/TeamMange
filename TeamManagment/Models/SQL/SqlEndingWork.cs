using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Models.SQL
{
    public class SqlEndingWork : IEndingWork
    {
        public TeamMangmentContext cnt;
        public UserManager<IdentityUser> userManager;
        IEmployee ie;
        IWorkTime iw;
        IEmployeeHoliday ieh;
        IHolidaySettings ih;
        ICompany ic;
        public SqlEndingWork(IEmployee ie, IWorkTime iw, IEmployeeHoliday ieh,
            IHolidaySettings ih, ICompany ic)
        {
            this.ie = ie;
            this.iw = iw;
            this.ieh = ieh;
            this.ih = ih;
            this.ic = ic;
        }
        public void GetWorkDone()
        {
            List<WorkTime> ws = iw.GetAllWorkTimes().Where(c => c.TheDate.Date == DateTime.Now.Date).ToList();
            List<Employee> emps = ie.GetAllEmployees().ToList();
            foreach (var it in emps)
            {
               int hour = it.workHours;
                foreach (var item in ws)
                {
                    if (item.EmployeeID == it.EmployeeID)
                    {
                        var h = item.WorkStart.TimeOfDay.TotalHours + hour;
                        if (DateTime.Now.Hour >= h)
                        {
                            item.WorkEndDone = true;
                            item.WorkEnd = DateTime.Now;
                            iw.UpdateWorkTime(item);
                        }
                    }
                }
            }
        }
        public void StartDate()
        {
            List<Employee> emps = ie.GetAllEmployees().ToList();
            foreach (var it in emps)
            {
                WorkTime wt = new WorkTime()
                {
                    EmployeeID = it.EmployeeID,
                    States = 0,
                    TheDate = DateTime.Now,
                    TheDay = DateTime.Now.DayOfWeek.ToString(),
                };
                iw.AddWorkTime(wt);
                Holiday(wt.WorkTimeID);
            }
        }
        public void Holiday(int WID)
        {
            WorkTime wt = iw.GetWorkTime(WID);
            List<HolidaySetting> hols = ih.GetAllHolidaySettings().ToList();
            foreach (var itm in hols)
            {
                var dates = IsHolidayDate(itm.FirstDay,itm.LastDay);
                if (dates.Contains(wt.TheDate.Date))
                {
                    wt.HolidayOrNot = true;
                    iw.UpdateWorkTime(wt);
                    break;
                }
            }
            List<CompanyInfromation> com = ic.GetAllCompanyInfromations().ToList();
            foreach (var itm in com)
            {
                var dates = IsHolidayDay(itm.WorkFirstDay, itm.WorkLastDay);
                if (!dates.Contains(wt.TheDate.DayOfWeek))
                {
                    wt.HolidayOrNot = true;
                    iw.UpdateWorkTime(wt);
                    break;
                }
            }
        }
        public List<DateTime> IsHolidayDate(DateTime satrtDate,DateTime endDate)
        {
            List<DateTime> dates = new List<DateTime>();
            while (satrtDate <= endDate) 
            {
                dates.Add(satrtDate);
                satrtDate = satrtDate.AddDays(1);
            }
            return dates;
        }

        public List<DayOfWeek> IsHolidayDay(DayOfWeek satrtDay, DayOfWeek endDay)
        {
            //var culture = new System.Globalization.CultureInfo("ar-AE");
            //var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            List<DayOfWeek> dates = new List<DayOfWeek>();
            while (satrtDay != endDay)
            {
                dates.Add(satrtDay);
                satrtDay = satrtDay + 1;

            }
            return dates;
        }

    }
}
