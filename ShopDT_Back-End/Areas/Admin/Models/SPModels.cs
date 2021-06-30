using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDT_Back_End.Areas.Admin.Models
{
    public class SPModels
    {
        private DataContext db;
        public SPModels()
        {
            db = new DataContext();
        }
        public List<SanPham> DanhSachSP()
        {
            return db.SanPhams.ToList();
        }
        public void InsertSP(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }
        public List<LoaiSanPham> DanhSachLSP()
        {
            return db.LoaiSanPhams.ToList();
        }
        public void EditSP(int id, SanPham sp)
        {
            SanPham old = getByID(id);
            old.TenSP = sp.TenSP;
            old.MaNhaSX = sp.MaNhaSX;
            old.MaLoaiSP = sp.MaLoaiSP;
            old.Gia = sp.Gia;
            old.TinhTrang = sp.TinhTrang;
            old.GhiChu = sp.GhiChu;
            db.SaveChanges();
        }
        //public void DeleteSP(int id, SanPham sp)
        //{
        //    var 
        //}

        public SanPham getByID(int id)
        {
            return db.SanPhams.Where(p => p.MaSP == id).FirstOrDefault();
        }

        public void DeleteSP(int id)
        {
            SanPham sp = db.SanPhams.Where(p => p.MaSP == id).FirstOrDefault();
            db.SanPhams.Remove(sp);
            db.SaveChanges();
          
        }
    }
}