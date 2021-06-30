using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseIO
{
    public class DBIO
    {
        DataContext mydb = new DataContext();

        public List<LoaiSanPham> GetList_LoaiSanPham()
        {
            return mydb.LoaiSanPhams.ToList();
        }

        public List<SanPham> GetList_SanPham()
        {
            return mydb.SanPhams.ToList();
        }
        public SanPham getSPByID(int id)
        {
            return mydb.SanPhams.Where(p => p.MaSP == id).FirstOrDefault();
        }

        //SanPhamBCModel

        public List<SanPhamBanChay> GetList_SanPhamBanChay()
        {
            return mydb.SanPhamBanChays.ToList();
        }

        public SanPhamBanChay getSPBCByID(int id)
        {
            return mydb.SanPhamBanChays.Where(p => p.MaSP == id).FirstOrDefault();
        }
    }
}
