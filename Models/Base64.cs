using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Beer_Vendas.Models
{
    public class Base64
    {
        public void Base64ToImage(string source)
        {
            try
            {
                string base64 = source.Substring(source.IndexOf(',') + 1);
                base64 = base64.Trim('\0');
                byte[] chartData = Convert.FromBase64String(base64);
            }
            catch
            {
                throw;
            }

        }
    }
}
