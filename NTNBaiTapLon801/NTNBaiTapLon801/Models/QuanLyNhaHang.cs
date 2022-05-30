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
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<BanAn> BanAns { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }
    }