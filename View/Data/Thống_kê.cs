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

        [Column("Số hóa đơn")]
        public int? Số_hóa_đơn { get; set; }

        public virtual Hóa_đơn Hóa_đơn { get; set; }
    }
}
