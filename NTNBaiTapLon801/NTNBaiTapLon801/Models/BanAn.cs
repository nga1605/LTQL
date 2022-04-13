using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NTNBaiTapLon801.Models
{
    [Table("BanAns")]
    public class BanAn
    {
        [Key]
        public string BanAnID { get; set; }
        public string TrangthaiBanAn { get; set; }
        public string DanhsachBanAn { get; set; }
    }
}