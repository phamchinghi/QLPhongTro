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

        [Column("Tên người dùng")]
        [Required]
        [StringLength(30)]
        public string Tên_người_dùng { get; set; }
    }
}
