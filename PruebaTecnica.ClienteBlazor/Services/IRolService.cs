using PruebaTecnica.ClienteBlazor.Models;

namespace PruebaTecnica.ClienteBlazor.Services
{
    public interface IRolService
    {
        Task<IEnumerable<Rol>> GetAll();
    }
}
