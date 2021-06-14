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

            cliente.BaseAddress = new Uri("https://tcc-nodejs-mysql.herokuapp.com/");

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

        public async Task<bool> GetLogin(Login Login)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(Login);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tcc-nodejs-mysql.herokuapp.com/usuarioLogin"),
                Content = new StringContent(json, Encoding.UTF8, "Application/json"),
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);


            if (responseBody != "[]")
                return true;
            else
                return false;

        }

        //Listar todos os Produtos (API ONLINE)
        public async Task<List<Produto>> GetProdutosAsync()
        {
            HttpResponseMessage response = await cliente.GetAsync("produto");

            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                var Produtos = JsonConvert.DeserializeObject<List<Produto>>(dados);

                return Produtos;
            }

            return new List<Produto>();
        }

        //Listar todos os Pedidos (API ONLINE)
        public void PostProdutos(Produto produtos)
        {
            WebRequest request = WebRequest.Create("https://tcc-nodejs-mysql.herokuapp.com/produto");
            request.Method = "POST";
            request.ContentType = "Application/json";
            string json = JsonConvert.SerializeObject(produtos);
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

        public async Task<List<Pedido>> ListarPedido(Usuario usuario)
        {

            string json = JsonConvert.SerializeObject(usuario);

            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://tcc-nodejs-mysql.herokuapp.com/pedidoLatestpurchases";
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = await response.Content.ReadAsStringAsync();

            List<Pedido> Pedidos = JsonConvert.DeserializeObject<List<Pedido>>(result);

            return Pedidos;
        }

        public void CriarUsuario(Usuario usuario)
        {
            usuario.usu_login = usuario.usu_email;
            usuario.usu_telefone = "014958545484";
            WebRequest request = WebRequest.Create("https://tcc-nodejs-mysql.herokuapp.com/Usuario");
            request.Method = "POST";
            request.ContentType = "Application/json";
            string json = JsonConvert.SerializeObject(usuario);
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
