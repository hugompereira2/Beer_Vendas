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
    }
}
