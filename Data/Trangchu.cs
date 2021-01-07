namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trangchu")]
    public partial class Trangchu
    {
        [Key]
        [Column("Mã KH", Order = 0)]
        [StringLength(5)]
        public string Mã_KH { get; set; }

        [Key]
        [Column("Mã phòng", Order = 1)]
        [StringLength(5)]
        public string Mã_phòng { get; set; }

        [Key]
        [Column("Họ tên", Order = 2)]
        [StringLength(30)]
        public string Họ_tên { get; set; }

        [Key]
        [Column("Năm sinh", Order = 3, TypeName = "date")]
        public DateTime Năm_sinh { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string Sđt { get; set; }

        [Column("Giới tính")]
        [StringLength(4)]
        public string Giới_tính { get; set; }

        [Key]
        [Column("Quê quán", Order = 5)]
        [StringLength(50)]
        public string Quê_quán { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(9)]
        public string CMND { get; set; }
    }
}
