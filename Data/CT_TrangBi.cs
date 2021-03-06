namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_TrangBi
    {
        [Key]
        [Required]
        [Column("Mã phòng", Order = 0)]
        [StringLength(5)]
        public string Mã_phòng { get; set; }

        [Key]
        [Required]
        [Column("Ma thiết bị", Order = 1)]
        [StringLength(5)]
        public string Ma_thiết_bị { get; set; }

        [Column("SL trang bi")]
        public int SL_trang_bi { get; set; }

        [Column("Ngày trang bị", TypeName = "date")]
        public DateTime Ngày_trang_bị { get; set; }


        public virtual Phòng Phòng { get; set; }

        public virtual Thiết_bị Thiết_bị { get; set; }
    }
}
