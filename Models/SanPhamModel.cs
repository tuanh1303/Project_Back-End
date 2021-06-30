using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SanPhamModel
    {
        private DataContext context = null;

        public SanPhamModel()
        {
            context = new DataContext();
        }
        

        public List<SanPham> ListAll()
        {
            var list = context.Database.SqlQuery<SanPham>("Sp_SanPham_ListAll").ToList();
            return list;
        }

        public bool AddSP(SanPham sp)
        {
            return context.SanPhams.Add(sp) != null ;
        }

        public SanPham getbyId(int id) 
        {
            return context.SanPhams.Where(p => p.MaSP == id).FirstOrDefault();
        }
     
    }
}
