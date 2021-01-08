namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            Hóa_đơn = new HashSet<Hóa_đơn>();
        }

        [Key]
        [StringLength(5)]
        public string SoHD { get; set; }

        public DateTime? NgayLapHD { get; set; }

        public DateTime? ThoiHanHD { get; set; }

        [Column("Mã KH")]
        [StringLength(5)]
        public string Mã_KH { get; set; }

        [Column("Mã phòng")]
        [StringLength(5)]
        public string Mã_phòng { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hóa_đơn> Hóa_đơn { get; set; }

        public virtual Nhân_viên_QL Nhân_viên_QL { get; set; }

        public virtual Khách_hàng Khách_hàng { get; set; }

        public virtual Phòng Phòng { get; set; }
    }
}
