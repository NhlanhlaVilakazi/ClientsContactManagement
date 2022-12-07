using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.Data.RepositoryService;
using Microsoft.EntityFrameworkCore;

namespace ClientsContactManagement.Data
{
    public class DataContext: DbContext, IDbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public static DataContext Create()
        {
            return new DataContext();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ClientsContactManagementConnection") ?? throw new Exception("Please setup environment variable: ClientsContactManagementConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasNoKey().ToView(null);
            modelBuilder.Entity<Contact>().HasNoKey().ToView(null);
        }
    }
}
