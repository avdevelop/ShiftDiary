/***************************************************************************\
Module Name:    HomeController
Author:         Viral Christian
Description:    

\***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShiftDiary.Helpers;
using ShiftDiary.DTO;

namespace ShiftDiary.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            
        }

        //
        // GET: /Home/
        // GET: /Home/Index        
        public ActionResult Index()
        {
            return View("Index");
        }

        //
        // GET: /Home/InvalidParams
        public ActionResult InvalidParams()
        {
            return View("InvalidParams");
        }        
    }
}
