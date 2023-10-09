namespace PruebaTecnica.ClienteBlazor.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Top_Aux { get; set; }
        public List<Usuario> Usuario { get; set; }
    }
}
