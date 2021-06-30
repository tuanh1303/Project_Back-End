namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BinhLuan")]
    public partial class BinhLuan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBL { get; set; }

        public string NoiDungBL { get; set; }

        [StringLength(20)]
        public string TenDangNhap { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaSP { get; set; }

        public virtual DangNhapKH DangNhapKH { get; set; }
    }
}
