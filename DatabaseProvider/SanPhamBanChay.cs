namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPhamBanChay")]
    public partial class SanPhamBanChay
    {
        [Key]
        public int MaSP { get; set; }

        [StringLength(250)]
        public string TenSP { get; set; }

        public int? MaLoaiSP { get; set; }

        public int? MaNhaSX { get; set; }

        [StringLength(50)]
        public string HinhAnhSP { get; set; }

        public decimal? Gia { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [StringLength(5)]
        public string TinhTrang { get; set; }

        public int? SoLuong { get; set; }

        public int? TongTien { get; set; }
    }
}
