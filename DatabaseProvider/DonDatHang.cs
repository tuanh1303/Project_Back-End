namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonDatHang")]
    public partial class DonDatHang
    {
        [Key]
        public int MaDDH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGiao { get; set; }

        public bool? DaThanhToan { get; set; }

        public int? MaKH { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
