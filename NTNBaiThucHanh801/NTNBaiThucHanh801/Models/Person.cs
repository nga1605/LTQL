using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NTNBaiThucHanh801.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string personID { get; set; }
        public string personName { get; set; }
    }
}