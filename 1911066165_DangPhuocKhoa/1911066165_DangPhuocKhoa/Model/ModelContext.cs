using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _1911066165_DangPhuocKhoa.Model
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<NguoiDan> NguoiDans { get; set; }
        public virtual DbSet<XetNghiem> XetNghiems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<XetNghiem>()
                .HasMany(e => e.NguoiDans)
                .WithOptional(e => e.XetNghiem)
                .HasForeignKey(e => e.XNLan1);

            modelBuilder.Entity<XetNghiem>()
                .HasMany(e => e.NguoiDans1)
                .WithOptional(e => e.XetNghiem1)
                .HasForeignKey(e => e.XNLan2);
        }
    }
}
