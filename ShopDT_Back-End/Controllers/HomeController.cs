using DatabaseIO;
using DatabaseProvider;
using ShopDT_Back_End.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDT_Back_End.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            DBIO db = new DBIO();
            List<LoaiSanPham> list = db.GetList_LoaiSanPham();
            return View(list);
        }

       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}