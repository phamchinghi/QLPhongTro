namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSKhachHang")]
    public partial class DSKhachHang
    {
        [Key]
        [Column("Mã KH", Order = 0)]
        [StringLength(5)]
        public string Mã_KH { get; set; }

        [Column("Mã phòng")]
        [StringLength(5)]
        public string Mã_phòng { get; set; }

        [Key]
        [Column("Tên KH", Order = 1)]
        [StringLength(30)]
        public string Tên_KH { get; set; }

        [Column("Năm sinh")]
        public DateTime? Năm_sinh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Sđt { get; set; }

        [Column("Giới tính")]
        [StringLength(4)]
        public string Giới_tính { get; set; }

        [Key]
        [Column("Quê quán", Order = 3)]
        [StringLength(50)]
        public string Quê_quán { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(9)]
        public string CMND { get; set; }
    }
}
