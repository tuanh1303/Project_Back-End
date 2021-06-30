namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }

        public int? MaSP { get; set; }

        public int? SoLuong { get; set; }

        public decimal? TongTien { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
