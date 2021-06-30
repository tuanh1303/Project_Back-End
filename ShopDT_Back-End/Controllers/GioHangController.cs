using Models;
using ShopDT_Back_End.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DatabaseProvider;
using Models;

namespace ShopDT_Back_End.Controllers
{
    public class GioHangController : Controller
    {
        private string CartSession = "CartSession";
        // GET: GioHang
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<GHItem>();
            if(cart != null)
            {
                list = (List<GHItem>)cart;
            }
            return View(list);
        }

        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<GHItem>>(cartModel);
            var sessionCart = (List<GHItem>)Session[CartSession];

            foreach (var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.sp.MaSP == item.sp.MaSP);
                if (jsonItem != null)
                {
                    item.SoLuong = jsonItem.SoLuong;
                }
            }
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }


        public JsonResult Delete(int id)
        {
            var sessionCart = (List<GHItem>)Session[CartSession];
            sessionCart.RemoveAll(x => x.sp.MaSP == id); 
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }


        public ActionResult AddItem(int IDSP, int SoLuong)
        {
          
            var cart = Session[CartSession];
            if(cart != null)
            {
                var list = (List<GHItem>)cart;
                if(list.Exists(x => x.SP == IDSP))
                {
                    foreach (var item in list)
                    {
                        if (item.SP == IDSP)
                        {
                            item.SoLuong += SoLuong;
                        }
                    }
                }else
                {
                    //Tạo mới đối tượng cartitem
                    var item = new GHItem(IDSP,SoLuong);
                   
                    list.Add(item);


                }
            }
            else
            {
                //Tạo mới đối tượng cartitem
                var item = new GHItem(IDSP,SoLuong);
               
                var list = new List<GHItem>();
                list.Add(item);

                //Gán vào Session
                Session[CartSession] = list;

            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Payment()
        {
            var cart = Session[CartSession];
            var list = new List<GHItem>();
            if (cart != null)
            {
                list = (List<GHItem>)cart;
            }
            return View(list);
        }
        [HttpPost]
        public ActionResult Payment(string NguoiNhan, string DienThoai, string DiaChi,string Email)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.NgayMua = DateTime.Now;
            hoaDon.NguoiNhan = NguoiNhan;
            hoaDon.DienThoai = DienThoai;
            hoaDon.Diachi = DiaChi;
            hoaDon.Email = Email;

                int id = new HoaDonModel().Insert(hoaDon);
                var cart = (List<GHItem>)Session[CartSession];
                var chiTietModel = new ChiTietHDModel();
            foreach (var item in cart)
            {
                var chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.MaHoaDon = item.SP;
                chiTietHoaDon.SoLuong = item.SoLuong;
                chiTietHoaDon.TongTien = item.SP;
                chiTietModel.Insert(chiTietHoaDon);
            }
            return Redirect("/Giohang/success");
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}