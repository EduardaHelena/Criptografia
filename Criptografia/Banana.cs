using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    class Banana
    {
       public  string senha;
       
        
        public string getMD5Hash(string senha)
        {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(senha);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
      
        for (int i = 0; i < hash.Length; i++)
        {
             sb.Append(hash[i].ToString("X2"));
        }
        
           return sb.ToString();
        }

       
    }
}










