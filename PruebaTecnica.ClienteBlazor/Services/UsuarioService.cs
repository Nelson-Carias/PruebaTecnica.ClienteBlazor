using PruebaTecnica.ClienteBlazor.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace PruebaTecnica.ClienteBlazor.Services
{
    public class UsuarioService : IUsuarioService
    {
        //Inyeccion de dependencias de HttpClient
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Usuario");
            return JsonSerializer.Deserialize<IEnumerable<Usuario>>(resp, options);
        }

        //public async Task<IEnumerable<Usuario>> GetLogin()
        //{
        //    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //    string resp = await _httpClient.PostAsJsonAsync($"Usuario/Login");
        //    return JsonSerializer.Deserialize<IEnumerable<Usuario>>(resp, options);
        //}

        //public async Task<IEnumerable<Usuario>> GetByLogin(int idUsuario)
        //{
        //    var resp = await _httpClient.PostAsJsonAsync($"Usuario/Login", new { idUsuario = idUsuario });
        //    string respString = await resp.Content.ReadAsStringAsync();
        //    return JsonSerializer.Deserialize<IEnumerable<Usuario>>(respString, options);
        //}
    }
}
