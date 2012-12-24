using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShiftDiary.Web.Controllers
{
    public class CalendarController : Controller
    {
        //
        // GET: /Calendar/

        public ActionResult Index()
        {
            DateTime now = DateTime.Now;

            ViewBag.CurrentMonth = now.ToString("MMMM");
            ViewBag.CurrentMonthInt = now.ToString("MM");
            ViewBag.CurrentYear = now.ToString("yyyy");

            List<DateTime> week = new List<DateTime>();
            List<List<DateTime>> weeks = new List<List<DateTime>>();

            for(int i = 1;i <= DateTime.DaysInMonth(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt)); i++)
            {
                DateTime dt = new DateTime(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt), i);

                week.Add(dt);

                if (dt.DayOfWeek == DayOfWeek.Sunday || i == DateTime.DaysInMonth(int.Parse(ViewBag.CurrentYear), int.Parse(ViewBag.CurrentMonthInt)))
                {                    
                    weeks.Add(week);
                    week = new List<DateTime>();
                }
            }

            ViewBag.Weeks = weeks;

            return View("Index");
        }

    }
}
