using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beer_Vendas.Models
{
    public class Usuario
    {
        public int usu_id { get; set; }
        public string usu_nome { get; set; }

        public string usu_sobrenome { get; set; }
        public bool usu_admin { get; set; }
        public string usu_login { get; set; }
        public string usu_senha { get; set; }
        public string usu_email { get; set; }
        public string usu_telefone { get; set; }

    }
}
