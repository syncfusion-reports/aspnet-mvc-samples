﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportsMVCSamples.Controllers
{
    public class PersonalExpenseAnalysisController : PreviewController
    {
        // GET: PersonalExpenseAnalysis
        public ActionResult Index()
        {
            return View();
        }
    }
}