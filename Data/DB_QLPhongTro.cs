namespace QL_PhongTro.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_QLPhongTro : DbContext
    {
        public DB_QLPhongTro()
            : base("name=DB_QLPhongTro")
        {
        }

        public virtual DbSet<CT_TrangBi> CT_TrangBi { get; set; }
        public virtual DbSet<Điện> Điện { get; set; }
        public virtual DbSet<Hóa_đơn> Hóa_đơn { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<Khách_hàng> Khách_hàng { get; set; }
        public virtual DbSet<Loại_phòng> Loại_phòng { get; set; }
        public virtual DbSet<Loại_thiết_bị> Loại_thiết_bị { get; set; }
        public virtual DbSet<Nước> Nước { get; set; }
        public virtual DbSet<Phòng> Phòng { get; set; }
        public virtual DbSet<Rác> Rác { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tài_khoản> Tài_khoản { get; set; }
        public virtual DbSet<Thiết_bị> Thiết_bị { get; set; }
        public virtual DbSet<Thống_kê> Thống_kê { get; set; }
        public virtual DbSet<Wifi> Wifis { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }
        public virtual DbSet<DSKhachHang> DSKhachHangs { get; set; }
        public virtual DbSet<Trangchu> Trangchus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_TrangBi>()
                .Property(e => e.Mã_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_TrangBi>()
                .Property(e => e.Ma_thiết_bị)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Điện>()
                .Property(e => e.Mã_điện)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hóa_đơn>()
                .Property(e => e.Mã_nước)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hóa_đơn>()
                .Property(e => e.Mã_wifi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hóa_đơn>()
                .Property(e => e.Mã_rác)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hóa_đơn>()
                .Property(e => e.Mã_xe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hóa_đơn>()
                .Property(e => e.Mã_điện)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.Mã_KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.Mã_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .HasMany(e => e.Hóa_đơn)
                .WithRequired(e => e.HOPDONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khách_hàng>()
                .Property(e => e.Mã_KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khách_hàng>()
                .Property(e => e.Sđt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khách_hàng>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khách_hàng>()
                .Property(e => e.Mã_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loại_phòng>()
                .Property(e => e.Mã_loại_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loại_phòng>()
                .HasMany(e => e.Phòng)
                .WithRequired(e => e.Loại_phòng)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loại_thiết_bị>()
                .Property(e => e.Mã_loại_TB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loại_thiết_bị>()
                .HasMany(e => e.Thiết_bị)
                .WithRequired(e => e.Loại_thiết_bị)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nước>()
                .Property(e => e.Mã_nước)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phòng>()
                .Property(e => e.Mã_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phòng>()
                .Property(e => e.Mã_loại_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phòng>()
                .Property(e => e.Huong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phòng>()
                .HasMany(e => e.CT_TrangBi)
                .WithRequired(e => e.Phòng)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phòng>()
                .HasMany(e => e.HOPDONGs)
                .WithRequired(e => e.Phòng)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rác>()
                .Property(e => e.Mã_rác)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thiết_bị>()
                .Property(e => e.Ma_thiết_bị)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thiết_bị>()
                .Property(e => e.Mã_loại_TB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thiết_bị>()
                .HasMany(e => e.CT_TrangBi)
                .WithRequired(e => e.Thiết_bị)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Thống_kê>()
                .Property(e => e.Số_phiếu_TK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Wifi>()
                .Property(e => e.Mã_wifi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.Mã_xe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKhachHang>()
                .Property(e => e.Mã_KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKhachHang>()
                .Property(e => e.Mã_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKhachHang>()
                .Property(e => e.Sđt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKhachHang>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trangchu>()
                .Property(e => e.Mã_KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trangchu>()
                .Property(e => e.Mã_phòng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trangchu>()
                .Property(e => e.Sđt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trangchu>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
