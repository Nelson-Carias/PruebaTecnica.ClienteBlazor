using PruebaTecnica.ClienteBlazor.Models;
using System.Text.Json;

namespace PruebaTecnica.ClienteBlazor.Services
{
    public class RolService : IRolService
    {
        //Inyeccion de dependencias de HttpClient
        private readonly HttpClient _httpClient;

        public RolService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Rol>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Rol");
            return JsonSerializer.Deserialize<IEnumerable<Rol>>(resp, options);
        }
    }
}
