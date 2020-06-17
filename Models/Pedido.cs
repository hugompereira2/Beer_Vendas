using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beer_Vendas.Models
{
    public class Pedido
    {
        public int ped_id { get; set; }
        public string ped_cli_id { get; set; }
        public DateTime ped_dtinclusao { get; set; }
        public float ped_vltotal { get; set; }
        public int ped_qtditens { get; set; }
        public string ped_situacao { get; set; }

    }
}
