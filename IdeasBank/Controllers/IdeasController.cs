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
        public JsonResult GetPage(int pageNumber = 1, int pageSize = 3)
        {
            try
            {
                IdeasBankEntities db = new IdeasBankEntities();
                var page = db.Ideas.OrderBy((a) => a.Id)
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize);
                return Json(page, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e.ToString(), JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public JsonResult Create(Ideas idea)
        {
            IdeasBankEntities db = new IdeasBankEntities();
            db.Ideas.Add(idea);
            db.SaveChanges();
            db.Dispose();
            return Json("success");
        }
    }
}
