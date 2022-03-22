using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace NTNBaiThucHanh801
{
    public class StringProcess
    {
            string strKey;
            string numPart, strPhanSo = "";
            public string AutoGenerateCode(string ID)
            {
                string text = "STD";
                numPart = Regex.Match(ID, @"\d+").Value;
                int phanso = (Convert.ToInt32(numPart) + 1);
                int len = phanso.ToString().Length - numPart.Length;
                for (int i = 0; i < len; i++)
                {
                    strPhanSo += "0";
                }
                strPhanSo += phanso;
                strKey = text + strPhanSo;

                return strKey;
            }
        }
    }
