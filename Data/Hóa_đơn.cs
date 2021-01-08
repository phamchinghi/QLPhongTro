namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hóa đơn")]
    public partial class Hóa_đơn
    {
        [Key]
        [Column("Số hóa đơn")]
        [StringLength(5)]
        public string Số_hóa_đơn { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNV { get; set; }

        [Column("Mã DV")]
        [StringLength(5)]
        public string Mã_DV { get; set; }

        [StringLength(5)]
        public string SoHD { get; set; }

        public virtual DỊch_vụ DỊch_vụ { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual Nhân_viên_QL Nhân_viên_QL { get; set; }
    }
}
