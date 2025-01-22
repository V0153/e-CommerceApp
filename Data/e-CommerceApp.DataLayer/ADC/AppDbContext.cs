using e_CommerceApp.EntitiyLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_CommerceApp.DataLayer.ADC
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Roman",OrderNo = 1},
                new Category { Id = 2, Name = "Hikaye",OrderNo = 2},
                new Category { Id = 3, Name = "Şiir",OrderNo = 3}
                );
        }
    }
}
