using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDT_Back_End.Areas.Admin.Models
{
    public class HDModel
    {
        private DataContext db;
        public HDModel()
        {
            db = new DataContext();
        }
        public List<HoaDon> DanhSachHD()
        {
            return db.HoaDons.ToList();
        }
        public List<LoaiSanPham> DanhSachLSP()
        {
            return db.LoaiSanPhams.ToList();
        }

        public HoaDon getByID(int id)
        {
            return db.HoaDons.Where(p => p.SoHoaDon == id).FirstOrDefault();
        }
    }
}