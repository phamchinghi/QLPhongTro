namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thống kê")]
    public partial class Thống_kê
    {
        [Key]
        [Column("Số phiếu TK")]
        [StringLength(5)]
        public string Số_phiếu_TK { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNV { get; set; }

        public virtual Nhân_viên_QL Nhân_viên_QL { get; set; }
    }
}
