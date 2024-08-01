using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Models
{
    public class ContactDBContext : DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; } = null;


    }
}
