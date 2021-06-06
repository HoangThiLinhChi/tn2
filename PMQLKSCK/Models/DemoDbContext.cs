using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PMQLKSCK.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<Acc> Accs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phong>()
               .Property(e => e.MaPhong)
               .IsFixedLength()
               .IsUnicode(false);
        }
    }
}
