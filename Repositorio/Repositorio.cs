using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Vendas.Models
{
    public class Repositorio
    {
        HttpClient cliente = new HttpClient();

        public Repositorio()
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
        //Listar todos os Produtos (API ONLINE)
        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            HttpResponseMessage response = await cliente.GetAsync("produto");

            if (response.IsSuccessStatusCode)
            {
                Base64 img = new Base64();
                var dados = await response.Content.ReadAsStringAsync();
                var Produtos = JsonConvert.DeserializeObject<IEnumerable<Produto>>(dados);
                return Produtos;
            }

            return new List<Produto>();
        }

        //Listar todos os Pedidos (API ONLINE)
        public void PostProdutos(Produto produtos)
        {
            WebRequest request = WebRequest.Create("http://localhost:3000/Produto");
            request.Method = "POST";
            request.ContentType = "Application/json";
            string json = "{\"Nome: " + produtos.pro_nome + ",\"Descricao: " + produtos.pro_descricao + ",\"Valor: " + produtos.pro_valor + ",\"Estoque: " + produtos.pro_estoque + "\"}";
            var byteArray = Encoding.UTF8.GetBytes(json);
            request.ContentLength = byteArray.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(byteArray, 0, byteArray.Length);
            stream.Close();

            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.Created)
                Console.Write("deu certo");
            else
                Console.Write("Falhou");
        }

        public async Task<IEnumerable<Pedido>> GetPedidosAsync()
        {
            HttpResponseMessage response = await cliente.GetAsync("pedido");

            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                var Pedidos = JsonConvert.DeserializeObject<IEnumerable<Pedido>>(dados);
                return Pedidos;
            }

            return new List<Pedido>();
        }
    }
}
