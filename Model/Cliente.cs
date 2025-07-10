namespace gestor_cdch.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string AreaInscrito { get; set; } = string.Empty;
        public DateTime FechaInscripcion { get; set; }

    }
}
