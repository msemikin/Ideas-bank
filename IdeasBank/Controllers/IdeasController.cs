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

            IdeasBankEntities db = new IdeasBankEntities();

            var page = db.Ideas.ToList();//.Skip(pageNumber * pageSize)
                    //.Take(pageSize);

            db.Dispose();
            return Json(page, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(Idea idea)
        {
            IdeasBankEntities db = new IdeasBankEntities();
            db.Ideas.Add(idea);
            db.SaveChanges();
            db.Dispose();
            return Json("success");
        }
    }
}
