using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDT_Back_End.Areas.Admin.Models
{
    public class ChiTietDHHModel
    {
        private DataContext db;
        public ChiTietDHHModel()
        {
            db = new DataContext();
        }
        public List<ChiTietDonDatHang> DanhSachChiTietDHH()
        {
            return db.ChiTietDonDatHangs.ToList();
        }
        public List<LoaiSanPham> DanhSachLSP()
        {
            return db.LoaiSanPhams.ToList();
        }

        public ChiTietDonDatHang getByID(int id)
        {
            return db.ChiTietDonDatHangs.Where(p => p.MaChiTietDDH == id).FirstOrDefault();
        }
    }
}