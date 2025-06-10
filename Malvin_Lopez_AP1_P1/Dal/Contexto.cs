using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Malvin_Lopez_AP1_P1.Dal
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Models.RegistroAportes> Registros { get; set; } = null!;

        public Contexto() { }
    }
}
