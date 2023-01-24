using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2_TEST.Data;
using WebApplication2_TEST.Models;

namespace WebApplication2_TEST.Pages.pCustomers
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication2_TEST.Data.ApplicationDbContext _context;

        public DetailsModel(WebApplication2_TEST.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public mCustomer Customers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }
            
            var customers = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }
            else 
            {
                Customers = customers;
            }
            return Page();
        }
    }
}
