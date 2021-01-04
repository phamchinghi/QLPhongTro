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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hóa_đơn()
        {
            Thống_kê = new HashSet<Thống_kê>();
        }

        [Key]
        [Column("Số hóa đơn")]
        public int Số_hóa_đơn { get; set; }

        [Column("Mã DV")]
        [Required]
        [StringLength(5)]
        public string Mã_DV { get; set; }

        public int SoHD { get; set; }

        [Column("Số điện tháng trước")]
        public int Số_điện_tháng_trước { get; set; }

        [Column("Số điện tháng này")]
        public int Số_điện_tháng_này { get; set; }

        [Column("Số nước tháng trước")]
        public int Số_nước_tháng_trước { get; set; }

        [Column("Số nước tháng này")]
        public int Số_nước_tháng_này { get; set; }

        [Column("Tổng tiền")]
        public int Tổng_tiền { get; set; }

        [Column("Ngày lập hóa đơn", TypeName = "date")]
        public DateTime Ngày_lập_hóa_đơn { get; set; }

        public virtual DỊch_vụ DỊch_vụ { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thống_kê> Thống_kê { get; set; }
    }
}
