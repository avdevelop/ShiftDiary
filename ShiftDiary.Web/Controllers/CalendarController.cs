using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShiftDiary.DTO;
using ShiftDiary.Web.ShiftService;

namespace ShiftDiary.Web.Controllers
{
    public class CalendarController : BaseController
    {
        private IShiftService shiftService;

        public CalendarController(IShiftService shiftService)
        {
            this.shiftService = shiftService;
        }

        //
        // GET: /Calendar/

        public ActionResult Index()
        {
            DateTime now = DateTime.Now;
            return View("Index", GenerateCalendarData(now));
        }

        //
        // GET: /Calendar/Month
        public ActionResult GotoMonth(int gotoMonth, int gotoYear)
        {
            DateTime date = new DateTime(gotoYear, gotoMonth, 1);
            return View("Index", GenerateCalendarData(date));
        }

        public Month GenerateCalendarData(DateTime now)
        {
            ViewBag.CurrentMonth = now.ToString("MMMM");
            ViewBag.CurrentMonthInt = now.ToString("MM");
            ViewBag.CurrentYear = now.ToString("yyyy");

            ViewBag.NextMonth = new DateTime(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt), 1).AddMonths(1).Month;
            ViewBag.PrevMonth = new DateTime(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt), 1).AddMonths(-1).Month;

            ViewBag.NextYear = new DateTime(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt), 1).AddMonths(1).Year;
            ViewBag.PrevYear = new DateTime(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt), 1).AddMonths(-1).Year;

            Week week = new Week();
            Month month = new Month(int.Parse(ViewBag.CurrentMonthInt), ViewBag.CurrentMonth, int.Parse(ViewBag.CurrentYear));

            for (int i = 1; i <= DateTime.DaysInMonth(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt)); i++)
            {
                DateTime dt = new DateTime(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt), i);
                Day day = new Day(dt);
                day.Shifts = shiftService.GetShiftForDay(day).ToList();

                week.Days.Add(day);

                if (dt.DayOfWeek == DayOfWeek.Sunday || i == DateTime.DaysInMonth(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt)))
                {
                    month.Weeks.Add(week);
                    week = new Week();
                }
            }            

            ViewBag.WeekDayCount = 0;

            return month;
        }

        public ActionResult ShiftDetails()
        {
            return View("ShiftDetails");
        }
    }
}
