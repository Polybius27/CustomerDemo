using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CustomerDemo.Data;
using CustomerDemo.Models;

namespace CustomerDemo.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly CustomerDemo.Data.CustomerDemoContext _context;

        public IndexModel(CustomerDemo.Data.CustomerDemoContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
