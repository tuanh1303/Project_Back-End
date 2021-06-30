using DatabaseIO;
using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDT_Back_End.Controllers
{
    public class SanPhamBCController : Controller
    {
        DBIO dBIO = new DBIO();
        // GET: SanPhamBC
        public ActionResult Index()
        {
            DBIO db = new DBIO();
            List<SanPhamBanChay> list = db.GetList_SanPhamBanChay();
            return View(list);
        }

        [HttpGet]
        public  ActionResult ChiTietSPBC(int id)
        {
            SanPhamBanChay model = dBIO.getSPBCByID(id);
            return View(model);
        }
    }
}