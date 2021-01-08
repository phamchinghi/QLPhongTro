namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khách hàng")]
    public partial class Khách_hàng
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khách_hàng()
        {
            HOPDONGs = new HashSet<HOPDONG>();
            Phòng = new HashSet<Phòng>();
        }

        [Key]
        [Column("Mã KH")]
        [StringLength(5)]
        public string Mã_KH { get; set; }

        [Column("Tên KH")]
        [StringLength(20)]
        public string Tên_KH { get; set; }

        [Column("Năm sinh")]
        public DateTime Năm_sinh { get; set; }

        [StringLength(10)]
        public string Sđt { get; set; }

        [StringLength(9)]
        public string CMND { get; set; }

        [Column("Quê quán")]
        [StringLength(50)]
        public string Quê_quán { get; set; }

        [Column("Giới tính")]
        [StringLength(4)]
        public string Giới_tính { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phòng> Phòng { get; set; }
    }
}
