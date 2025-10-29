using HastaneOtomasyon.Api.Models;
using Microsoft.EntityFrameworkCore;


namespace HastaneOtomasyon.Api.Data

{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Kullanici> Kullaniclar { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Recete> Receteler { get; set; }


    }
}
