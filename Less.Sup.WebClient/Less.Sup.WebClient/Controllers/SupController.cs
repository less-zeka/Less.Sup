﻿using System.Web.Mvc;

namespace Less.Sup.WebClient.Controllers
{
    public class SupController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View("Index", id);
        }
    }
}