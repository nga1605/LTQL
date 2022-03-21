using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTNBaiTapLon801.Models
{
    public partial class QuanLyNhaHang : DbContext
    {
        public QuanLyNhaHang()
            : base("name=QuanLyNhaHang")
        {
        }
        public virtual DbSet<QLBanAn> QLBanAns { get; set; }

        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
