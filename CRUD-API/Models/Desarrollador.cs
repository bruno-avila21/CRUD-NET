namespace CRUD_API.Models
{
    public class Desarrollador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public List<Experiencia> Experiencias { get; set; }
    }
}
