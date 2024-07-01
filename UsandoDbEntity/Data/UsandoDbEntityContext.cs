using Microsoft.EntityFrameworkCore;
using UsandoDbEntity.Models;


namespace UsandoDbEntity.Data
{
    internal class UsandoDbEntityContext: DbContext
    {
        private readonly string connectionString = "Data Source=GSANTOS\\SQLEXPRESS;Database = TesteDb; Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False";
        public UsandoDbEntityContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
        }

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

    }
}
