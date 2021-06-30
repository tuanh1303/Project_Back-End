using DatabaseIO;
using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDT_Back_End.Controllers
{
    public class LoaiSPController : Controller
    {
        // GET: LoaiSP
        public ActionResult Index()
        {
            DBIO db = new DBIO();
            List<SanPham> list = db.GetList_SanPham();
            return View(list);
        }

    }
}