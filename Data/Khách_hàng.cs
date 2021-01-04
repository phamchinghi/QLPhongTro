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
        }

        [Key]
        [Column("Mã KH")]
        [StringLength(5)]
        public string Mã_KH { get; set; }

        [Column("Tên KH")]
        [Required]
        [StringLength(30)]
        public string Tên_KH { get; set; }

        [Column("Năm sinh", TypeName = "date")]
        public DateTime Năm_sinh { get; set; }

        [Required]
        [StringLength(10)]
        public string Sđt { get; set; }

        [Required]
        [StringLength(9)]
        public string CMND { get; set; }

        [Column("Quê quán")]
        [Required]
        [StringLength(50)]
        public string Quê_quán { get; set; }

        [Column("Giới tính")]
        public string Giới_tính { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
    }
}
