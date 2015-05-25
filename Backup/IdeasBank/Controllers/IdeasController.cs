using IdeasBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace IdeasBank.Controllers
{
    public class IdeasController : Controller
    {
        [HttpGet]
        public JsonResult GetPage(int pageNumber, int pageSize)
        {
            IdeasBankDbContext db = new IdeasBankDbContext();
            var page = db.Ideas.Skip(pageNumber * pageSize)
                    .Take(pageSize);
            db.Dispose();
            return Json(page);
        }

        [HttpPost]
        public JsonResult Create(Idea idea)
        {
            IdeasBankDbContext db = new IdeasBankDbContext();
            db.Ideas.Add(idea);
            db.SaveChanges();
            db.Dispose();
            return Json("success");
        }
    }
}
