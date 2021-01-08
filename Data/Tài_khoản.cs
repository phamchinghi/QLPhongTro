namespace QL_PhongTro.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tài khoản")]
    public partial class Tài_khoản
    {
        [Key]
        [Column("User name")]
        [StringLength(20)]
        public string User_name { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        public virtual Nhân_viên_QL Nhân_viên_QL { get; set; }
    }
}
