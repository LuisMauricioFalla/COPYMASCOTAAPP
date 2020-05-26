namespace MASCOTAAPP.Models
{
    public class Mascota
    {
        public int ID { get; set; }
        public string NombreTemporal { get; set; }
        public int EdadAproximada { get; set; }
        public string Foto { get; set; }
        public TipoMascota Tipo { get; set; }
        public int TipoID { get; set; }

    }
}