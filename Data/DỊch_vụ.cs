namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DỊch vụ")]
    public partial class DỊch_vụ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DỊch_vụ()
        {
            Hóa_đơn = new HashSet<Hóa_đơn>();
        }

        [Key]
        [Column("Mã DV")]
        [StringLength(5)]
        public string Mã_DV { get; set; }

        [Column("Tên DV")]
        [StringLength(20)]
        public string Tên_DV { get; set; }

        [StringLength(10)]
        public string DVT { get; set; }

        [Column("Giá DV", TypeName = "money")]
        public decimal Giá_DV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hóa_đơn> Hóa_đơn { get; set; }
    }
}
