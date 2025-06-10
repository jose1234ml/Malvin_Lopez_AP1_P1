using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Malvin_Lopez_AP1_P1.Dal
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

<<<<<<< HEAD
        public DbSet<Models.RegistroAportes> Registros { get; set; } = null!;
=======
        public DbSet<Models.Registro> Registros { get; set; } = null!;
>>>>>>> eedd2445e43470a3512e0d3ff94ca31c2949198e

        public Contexto() { }
    }
}
