using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerDemo.Models;

namespace CustomerDemo.Data
{
    public class CustomerDemoContext : DbContext
    {
        public CustomerDemoContext (DbContextOptions<CustomerDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerDemo.Models.Customer> Customer { get; set; } = default!;
    }
}
