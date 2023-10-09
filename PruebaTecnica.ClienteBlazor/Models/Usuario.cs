namespace PruebaTecnica.ClienteBlazor.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public byte Estatus { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string ConfirmPassword_aux { get; set; }
        public int Top_Aux { get; set; }
        public Rol Rol { get; set; }
    }
}
