using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beer_Vendas.Models
{
    public class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Imagem { get; set; }
    }
}
