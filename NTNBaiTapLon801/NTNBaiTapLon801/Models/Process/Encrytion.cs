using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace NTNBaiTapLon801.Models.Process
{
    public class Encrytion
    {
        public string PassWordEncrytion(string pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "MD5");
        }

        internal string PasswordEncrytion(string passWord)
        {
            throw new NotImplementedException();
        }
    }
}