using Challenge_Flextech.Persistence.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Challenge_Flextech.Persistence.MsSql
{
    public class MsSqlContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovimientosBcraModel>()
                .HasNoKey();
        }
        public DbSet<MovimientosBcraModel> movimientosBcra { get; set; }
        public MsSqlContext(DbContextOptions<MsSqlContext> options) : base(options)
        {

        }
    }
}
