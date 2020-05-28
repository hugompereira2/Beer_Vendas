using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Beer_Vendas.Models
{
    public class UsuarioRepositorio
    {
        HttpClient cliente = new HttpClient();

        public UsuarioRepositorio()
        {

            cliente.BaseAddress = new Uri("http://localhost:3000/");

            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
        //Pegar todos os Usuários (API ONLINE)
        public async Task<IEnumerable<Usuario>> GetUsuariosAsync()
        {
            HttpResponseMessage response = await cliente.GetAsync("usuario");

            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                var Usuarios = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(dados);
                return Usuarios;
            }

            return new List<Usuario>();

        }
        //Pegar todos os Produtos (API ONLINE)
        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            HttpResponseMessage response = await cliente.GetAsync("produto");

            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                var Produtos = JsonConvert.DeserializeObject<IEnumerable<Produto>>(dados);
                return Produtos;
            }

            return new List<Produto>();
        }
    }
}
