namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int SoHoaDon { get; set; }

        public int? MaHoaDon { get; set; }

        public int? MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }

        [StringLength(50)]
        public string NguoiNhan { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? TrangThai { get; set; }
    }
}
