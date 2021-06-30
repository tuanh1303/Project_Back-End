using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseProvider;
using Models;
using ShopDT_Back_End.Areas.Admin.Models;

namespace ShopDT_Back_End.Areas.Admin.Controllers
{
    public class DonDatHangController : Controller
    {
        DHHModel dhh = new DHHModel();
        LoaiSPModel lsp = new LoaiSPModel();
        // GET: Admin/DonDatHang
        public ActionResult Index()
        {
            return View(dhh.DanhSachDHH());
        }
    }
}