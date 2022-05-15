using Doceria.Models;
using Microsoft.EntityFrameworkCore;

namespace Doceria.Persistence
{
    public class DoceriaContext : DbContext
    {
        public DoceriaContext(DbContextOptions options) : base(options) { }

        public DbSet<Torta> Tortas { get; set; }
    }
}
