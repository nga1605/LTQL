using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NTNBaiThucHanh801.Models
{
    [Table("students")]
    public class student
    {
        [Key]
        public string studentID { get; set; }
        public string studentName { get; set; }
    }
}