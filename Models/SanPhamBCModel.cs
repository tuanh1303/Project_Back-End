using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProvider;

namespace Models
{
    public class SanPhamBCModel
    {
        private DataContext context = null;

        public SanPhamBCModel()
        {
            context = new DataContext();
        }

        public List<SanPhamBanChay> ListAll()
        {
            var list = context.Database.SqlQuery<SanPhamBanChay>("Spbc_SanPhamBanChay_ListAll").ToList();
            return list;
        }

        public bool AddSPBC(SanPhamBanChay spbc)
        {
            return context.SanPhamBanChays.Add(spbc) != null;
        }

        public SanPhamBanChay getbyId(int id)
        {
            return context.SanPhamBanChays.Where(p => p.MaSP == id).FirstOrDefault();
        }
    }
}
