using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ViThuyVy.Models
{
    public partial class LTQLcontext : DbContext
    {
        public LTQLcontext()
            : base("name=LTQLcontext")
        {
        }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
