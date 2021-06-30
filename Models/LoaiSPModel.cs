using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LoaiSPModel
    {
        private DataContext dbc;
        public LoaiSPModel()
        {
            dbc = new DataContext();
        }

        public List<LoaiSanPham> getList()
        {
            return dbc.LoaiSanPhams.ToList();
        }

        public LoaiSanPham GetLoai(int id)
        {
            return dbc.LoaiSanPhams.Where(p => p.MaLoaiSP == id).FirstOrDefault();
        }
    }
}
