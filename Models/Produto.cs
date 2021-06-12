using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beer_Vendas.Models
{
    public class Produto
    {
        public int pro_id { get; set; }
        public string pro_nome { get; set; }
        public string pro_descricao { get; set; }
        public string pro_valor { get; set; }
        public int pro_estoque { get; set; }
        public string pro_imagem { get; set; }
        //public byte[] pro_imagem_src { get; set; }

    }
}
