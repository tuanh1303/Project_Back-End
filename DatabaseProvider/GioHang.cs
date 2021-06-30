namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioHang")]
    public partial class GioHang
    {
        public long ID { get; set; }

        [StringLength(128)]
        public string MaTK { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        public int? Soluong { get; set; }

        public int? Gia { get; set; }

        public int? TongTien { get; set; }
    }
}
