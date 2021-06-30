using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDT_Back_End.Areas.Admin.Models
{
    public class CTHoaDonModel
    {
        private DataContext db;
        public CTHoaDonModel()
        {
            db = new DataContext();
        }
        public List<ChiTietHoaDon> DanhSachCTHD()
        {
            return db.ChiTietHoaDons.ToList();
        }
        public List<LoaiSanPham> DanhSachLSP()
        {
            return db.LoaiSanPhams.ToList();
        }

        public ChiTietHoaDon getByID(int id)
        {
            return db.ChiTietHoaDons.Where(p => p.MaHoaDon == id).FirstOrDefault();
        }
    }
}