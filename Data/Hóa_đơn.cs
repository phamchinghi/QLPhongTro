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

        [Column("Mã nước")]
        [StringLength(5)]
        public string Mã_nước { get; set; }

        [Column("Mã wifi")]
        [StringLength(5)]
        public string Mã_wifi { get; set; }

        [Column("Mã rác")]
        [StringLength(5)]
        public string Mã_rác { get; set; }

        [Column("Mã xe")]
        [StringLength(5)]
        public string Mã_xe { get; set; }

        [Column("Mã điện")]
        [StringLength(5)]
        public string Mã_điện { get; set; }

        public virtual Điện Điện { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual Nước Nước { get; set; }

        public virtual Wifi Wifi { get; set; }

        public virtual Rác Rác { get; set; }

        public virtual Xe Xe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thống_kê> Thống_kê { get; set; }
    }
}
