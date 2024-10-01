using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class AppDbContext : DbContext
    {
        // Constructeur de la classe AppDbContext, prend en paramètre les options de configuration
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Représente la table Products dans la base de données
        public DbSet<Product> Products { get; set; }
    }
}
