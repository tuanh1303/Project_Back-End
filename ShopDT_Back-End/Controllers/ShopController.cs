using DatabaseIO;
using DatabaseProvider;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDT_Back_End.Controllers
{
    public class ShopController : Controller
    {
        DBIO dBIO = new DBIO();
        // GET: Shop
        public ActionResult Index()
        {
            DBIO db = new DBIO();
            List<SanPhamBanChay> list = db.GetList_SanPhamBanChay();
            return View(list);
        }

        [HttpGet]
        public ActionResult ChiTietSP(int id)
        {
            SanPham model = dBIO.getSPByID(id);
            return View(model);
        }

    }
}