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
        public string PersonID { get; set; }
        public string PersonName { get; set; }
    }
}