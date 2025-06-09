

using backend.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace backend.Context
{
    public class BackendContext : DbContext
    {
        public BackendContext(DbContextOptions<BackendContext> options) : base(options) { }

        DbSet<Atillo> Atillo { get; set; }
        DbSet<Roginand> Roginand { get; set; }
    }
}
