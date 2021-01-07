namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wifi")]
    public partial class Wifi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wifi()
        {
            Hóa_đơn = new HashSet<Hóa_đơn>();
        }

        [Key]
        [Column("Mã wifi")]
        [StringLength(5)]
        public string Mã_wifi { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        [Column("Giá wifi")]
        public int Giá_wifi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hóa_đơn> Hóa_đơn { get; set; }
    }
}
