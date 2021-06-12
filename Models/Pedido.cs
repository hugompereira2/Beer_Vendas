using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beer_Vendas.Models
{
    public class Pedido
    {
        public int ped_usu_id { get; set; }
        public int ped_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public float ped_vltotal { get; set; }
        public int ped_qtditens { get; set; }
        public char ped_situacao { get; set; }

    }
}
