using DatabaseProvider;
using Models;
using ShopDT_Back_End.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace ShopDT_Back_End.Areas.Admin.Controllers
{
    public class SanPhamAdminController : Controller
    {
        SPModels ds = new SPModels();
        LoaiSPModel lsp = new LoaiSPModel();
        // GET: Admin/SanPhamAdmin
        public ActionResult Index()
        {
            return View(ds.DanhSachSP());
        }

        // GET: Admin/SanPhamAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPhamAdmin/Create
        public ActionResult Create()
        {
            SetViewBag();         
            return View();
        }

        public void SetViewBag(long? selectedId = null)
        {
           
            ViewBag.MaLoaiSP = new SelectList(ds.DanhSachLSP(), "MaLoaiSP", "TenLoaiSP", selectedId);
        }

        // POST: Admin/SanPhamAdmin/Create
        [HttpPost]
       
        public ActionResult Create(SanPham sp)
        {
            
            try
            {
                SetViewBag();
                sp.TinhTrang = "0";
                
                // TODO: Add insert logic here
                ds.InsertSP(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Edit/5
        public ActionResult Edit(int id)

        {
            List<LoaiSanPham> listLoai = lsp.getList();
            SelectList sl = new SelectList(listLoai, "MaLoaiSP", "TenLoaiSP");
            ViewBag.ListLoai = sl;
            SanPham s = ds.getByID(id);
            return View(s);
        }


        // POST: Admin/SanPhamAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SanPham sp)
        {
            try
            {          
               
                ds.EditSP(id,sp);
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Delete/5
        public ActionResult Delete(int id,SanPham sp)
        {           
            List<LoaiSanPham> listLoai = lsp.getList();
            SelectList sl = new SelectList(listLoai, "MaLoaiSP", "TenLoaiSP");
            ViewBag.ListLoai = sl;
            SanPham s = ds.getByID(id);
            return View(s);
        }

        // POST: Admin/SanPhamAdmin/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)//id?
        {
            try
            {
                // TODO: Add delete logic here
                ds.DeleteSP(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
