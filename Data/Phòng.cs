namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phòng
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phòng()
        {
            CT_TrangBi = new HashSet<CT_TrangBi>();
            HOPDONGs = new HashSet<HOPDONG>();
        }

        [Key]
        [Column("Mã phòng")]
        [StringLength(5)]
        public string Mã_phòng { get; set; }

        [Column("Mã loại phòng")]
        [Required]
        [StringLength(5)]
        public string Mã_loại_phòng { get; set; }

        public int SucChua { get; set; }

        public int DTSD { get; set; }

        [StringLength(4)]
        public string Huong { get; set; }

        [Column("Giá phòng")]
        public int Giá_phòng { get; set; }

        [Column("Trạng thái")]
        [Required]
        [StringLength(10)]
        public string Trạng_thái { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TrangBi> CT_TrangBi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }

        public virtual Loại_phòng Loại_phòng { get; set; }
    }
}
