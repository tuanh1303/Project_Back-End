namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonDatHang")]
    public partial class ChiTietDonDatHang
    {
        [Key]
        public int MaChiTietDDH { get; set; }

        public int? MaDDH { get; set; }

        public int? MaSP { get; set; }

        [StringLength(250)]
        public string TenSP { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }
    }
}
