using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projectv2.DAL;
using Projectv2.ViewModels;

namespace Projectv2.Controllers
{
    public class HomeController : Controller
    {
        private PublishingContext db = new PublishingContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<AuthorsGroup> data =
                from book in db.Books
                group book by book.Writer into writerGroup
                select new AuthorsGroup()
                {
                    Writer = writerGroup.Key,
                    BooksCount = writerGroup.Count()
                };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}