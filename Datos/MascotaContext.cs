using MASCOTAAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace MASCOTAAPP.Datos
{
    public class MascotaContext : DbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }

        public DbSet<TipoMascota> Tipos { get; set; }

        public MascotaContext(DbContextOptions<MascotaContext> o) : base(o){
            
        }
        
    }
}