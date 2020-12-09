using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace StudentSupportApp
{
    class MD5Encoder
    {
        public string FromString(string Message)
        {
            MD5 MyMD5 = MD5.Create();
            byte[] HashCode = MyMD5.ComputeHash(Encoding.Unicode.GetBytes(Message));
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < HashCode.Length; i++)
                SB.Append(HashCode[i].ToString("X2"));
            return SB.ToString();
        }
    }
}
