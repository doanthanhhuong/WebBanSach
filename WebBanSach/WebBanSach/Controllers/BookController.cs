﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanSach.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BookShop()
        {
            return View();
        }
        public ActionResult BestSeller()
        {
            return View();
        }
    }
}