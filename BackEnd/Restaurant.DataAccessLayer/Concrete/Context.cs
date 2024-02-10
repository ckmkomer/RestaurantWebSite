using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restaurant.EntityLayer.Concrete;
using Restaurant.EntityLayer.Concrete.Identity;
using System.Drawing;
namespace Restaurant.DataAccessLayer.Concrete
   
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=OMER;Initial Catalog=Ecommerce_website;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
           

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Footer> Footers { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
