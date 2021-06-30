using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDT_Back_End.Areas.Admin.Models
{
    public class DHHModel
    {
        private DataContext db;
        public DHHModel()
        {
            db = new DataContext();
        }
        public List<DonDatHang> DanhSachDHH()
        {
            return db.DonDatHangs.ToList();
        }
        public List<LoaiSanPham> DanhSachLSP()
        {
            return db.LoaiSanPhams.ToList();
        }

        public DonDatHang getByID(int id)
        {
            return db.DonDatHangs.Where(p => p.MaDDH == id).FirstOrDefault();
        }
    }
}