using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTNBaiThucHanh801.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<student> Students { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Employee> Employees  { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
