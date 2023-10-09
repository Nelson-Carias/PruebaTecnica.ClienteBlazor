using PruebaTecnica.ClienteBlazor.Models;

namespace PruebaTecnica.ClienteBlazor.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAll();
    }
}
