namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            Hóa_đơn = new HashSet<Hóa_đơn>();
        }

        [Key]
        [Column("Mã xe")]
        [StringLength(5)]
        public string Mã_xe { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        [Column("Giá xe")]
        public int Giá_xe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hóa_đơn> Hóa_đơn { get; set; }
    }
}
