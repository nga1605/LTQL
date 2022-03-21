using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NTNBaiTapLon801.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string TenMonAn { get; set; }
        public int GiaTien { get; set; }
        public int SoLuong { get; set; }
    }
}