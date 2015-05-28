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
        public JsonResult GetPage(int pageNumber = 1, int pageSize = 1,
            bool freeAllowed= true, bool assignedAllowed = true)
        {
            try
            {
                string free = freeAllowed ? "Free" : "xxx";
                string assigned = assignedAllowed ? "Assigned" : "xxx";

                IdeasBankEntities db = new IdeasBankEntities();

                IEnumerable<Ideas> page = db.Ideas.Where((a) => a.Status.Contains(free));
                page = page.Union(db.Ideas.Where((a) => a.Status.Contains(assigned)));

                page = page.OrderBy((a) => a.Id)
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
        public ActionResult Create(Ideas idea)
        {
            IdeasBankEntities db = new IdeasBankEntities();
            idea.Id = db.Ideas.Count();
            idea.Date = DateTime.Now;
            idea.Status = "Free";
            db.Ideas.Add(idea);
            db.SaveChanges();
            db.Dispose();
            return RedirectToAction("Index", "Home");
        }
    }
}
