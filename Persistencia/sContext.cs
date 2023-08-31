using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Dominio;


namespace Persistencia;
public class sContext : DbContext {
    public sContext(DbContextOptions<sContext> options) : base(options) { 

    }
        //public DbSet<User> ?Users { get; set; }
        

        

       protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}