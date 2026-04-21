using Microsoft.EntityFrameworkCore;
using PRIMERA_API.Models;


namespace PRIMERA_API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<tabla1> tabla1 { get; set; }
        public DbSet<Tabla2> tabla2 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<tabla1>().HasData(
                new tabla1 { Id = 1, Nombre = "Fabian", Apellido = "Garcia" },
                new tabla1 { Id = 2, Nombre = "Paula", Apellido = "Dominguez" },
                new tabla1 { Id = 3, Nombre = "Dilan", Apellido = "Cruz" }
            );

            modelBuilder.Entity<Tabla2>().HasData(
                new Tabla2 { Id = 1, Color = "Rojo" },
                new Tabla2 { Id = 2, Color = "Verde" },
                new Tabla2 { Id = 3, Color = "Azul" }
            );

        }



    }
}
