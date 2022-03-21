using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NTNBaiTapLon801.Models
{
    [Table("MonAns")]
    public class MonAn
    {
        [Key]
        public string TenMonAn { get; set; }
        public int SoLuong { get; set; }
    }
}