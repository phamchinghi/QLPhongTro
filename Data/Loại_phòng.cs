namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loại phòng")]
    public partial class Loại_phòng
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loại_phòng()
        {
            Phòng = new HashSet<Phòng>();
        }

        [Key]
        [Column("Mã loại phòng")]
        [StringLength(5)]
        public string Mã_loại_phòng { get; set; }

        [StringLength(20)]
        public string TenLP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phòng> Phòng { get; set; }
    }
}
