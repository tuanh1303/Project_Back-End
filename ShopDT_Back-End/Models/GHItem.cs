using DatabaseProvider;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace ShopDT_Back_End.Models
{
    [Serializable]
    public class GHItem

    {
        SanPhamModel spmd = new SanPhamModel();
        SanPhamBCModel spbcmd = new SanPhamBCModel();

        //public SanPham SanPham { set; get; }
        public int SP { set; get; }
        public int SoLuong { set; get; }

        public SanPham sp { set; get; }

        public SanPhamBanChay bc { set; get; }
        
        public GHItem()
        {
            
        }

        public GHItem(int sP, int soLuong)
        {
            SP = sP;
            SoLuong = soLuong;
            this.sp = spmd.getbyId(sP);
        }


    }
}