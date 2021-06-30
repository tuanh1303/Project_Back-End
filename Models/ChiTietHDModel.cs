using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProvider;

namespace Models
{
    public class ChiTietHDModel
    {
        private DataContext context = null;

        public ChiTietHDModel()
        {
            context = new DataContext();
        }
        public bool Insert(ChiTietHoaDon chiTiet)
        {
            try
            {
                context.ChiTietHoaDons.Add(chiTiet);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
