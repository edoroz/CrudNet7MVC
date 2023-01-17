

using CrudNet7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet7MVC.Datos {
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        } //-ctr

        public DbSet<Contacto> Contactos { get; set; }

    } //-cls

} //-nsp
