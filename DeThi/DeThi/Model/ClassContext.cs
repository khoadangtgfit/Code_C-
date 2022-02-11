using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DeThi.Model
{
    public partial class ClassContext : DbContext
    {
        public ClassContext()
            : base("name=ClassContext")
        {
        }

        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOP>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.NGAYSINH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
