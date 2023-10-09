using PruebaTecnica.ClienteBlazor.Models;

namespace PruebaTecnica.ClienteBlazor.Services
{
    public interface IVehiculoService
    {
        Task<IEnumerable<Vehiculo>> GetAll();
    }
}
