using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProvider;

namespace Models
{
    public class HoaDonModel
    {
        private DataContext context = null;

        public HoaDonModel()
        {
            context = new DataContext();
        }
        public int Insert(HoaDon hoaDon)
        {
            HoaDon rs= context.HoaDons.Add(hoaDon);
            context.SaveChanges();
            return rs.SoHoaDon;
        }
    }
}
