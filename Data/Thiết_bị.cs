namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thiết bị")]
    public partial class Thiết_bị
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thiết_bị()
        {
            CT_TrangBi = new HashSet<CT_TrangBi>();
        }

        [Key]
        [Column("Ma thiết bị")]
        [StringLength(5)]
        public string Ma_thiết_bị { get; set; }

        [Required]
        [StringLength(30)]
        public string TenTB { get; set; }

        [Column("Mã loại TB")]
        [Required]
        [StringLength(5)]
        public string Mã_loại_TB { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }


        [Column("Đơn giá")]
        public int Đơn_giá { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TrangBi> CT_TrangBi { get; set; }

        public virtual Loại_thiết_bị Loại_thiết_bị { get; set; }

        public virtual Phòng Phòng { get; set; }
    }
}
