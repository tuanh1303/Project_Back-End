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
    public class CTHoaDonController : Controller
    {
        CTHoaDonModel cthdm = new CTHoaDonModel();
        LoaiSPModel lsp = new LoaiSPModel();
        // GET: Admin/CTHoaDon
        public ActionResult Index()
        {
            return View(cthdm.DanhSachCTHD());
        }
    }
}