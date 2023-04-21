using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler=c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
//Context sınıfından bir nesne üretip c nesnesi yardımıyla contexte bağlı olan sınıfların içerisinde hakkımızda olan
//tabloyu çekip bu tabloyu listele dedik.