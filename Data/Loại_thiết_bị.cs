namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loại thiết bị")]
    public partial class Loại_thiết_bị
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loại_thiết_bị()
        {
            Thiết_bị = new HashSet<Thiết_bị>();
        }

        [Key]
        [Column("Mã loại TB")]
        [StringLength(5)]
        public string Mã_loại_TB { get; set; }

        [Column("Tên loại TB")]
        [StringLength(30)]
        public string Tên_loại_TB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thiết_bị> Thiết_bị { get; set; }
    }
}
