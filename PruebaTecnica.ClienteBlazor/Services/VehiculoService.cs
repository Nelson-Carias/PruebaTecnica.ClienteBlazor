using PruebaTecnica.ClienteBlazor.Models;
using System.Text.Json;

namespace PruebaTecnica.ClienteBlazor.Services
{
    public class VehiculoService : IVehiculoService
    {
        //Inyeccion de dependencias de HttpClient
        private readonly HttpClient _httpClient;

        public VehiculoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Vehiculo>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Vehiculo");
            return JsonSerializer.Deserialize<IEnumerable<Vehiculo>>(resp, options);
        }
    }
}
