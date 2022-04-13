using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NTNBaiTapLon801.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string UserID { get; set; }
        [Required(ErrorMessage ="Họ và tên không được để trống!!!")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}