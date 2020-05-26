using System.Collections.Generic;

namespace MASCOTAAPP.Models
{
    public class TipoMascota
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Mascota> Mascotas { get; set; }
    }
}