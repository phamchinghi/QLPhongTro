namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Điện
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Điện()
        {
            Hóa_đơn = new HashSet<Hóa_đơn>();
        }

        [Key]
        [Column("Mã điện")]
        [StringLength(5)]
        public string Mã_điện { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        [Column("Giá điện")]
        public int Giá_điện { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hóa_đơn> Hóa_đơn { get; set; }
    }
}
