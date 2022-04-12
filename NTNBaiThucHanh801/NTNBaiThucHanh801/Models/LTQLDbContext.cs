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
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
    }
    }

