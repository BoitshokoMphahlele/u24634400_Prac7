using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u24634400_Prac7.Models;

namespace u24634400_Prac7.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult PublicationsView()
        {
            var publications = PublicationRepository.GetAllPublications();
            return View(publications);
        }
    }
}