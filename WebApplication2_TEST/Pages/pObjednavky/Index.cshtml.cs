﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2_TEST.Data;
using WebApplication2_TEST.Models;

namespace WebApplication2_TEST.Pages.pObjednavky
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication2_TEST.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication2_TEST.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<mOrders> Orders { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Orders != null)
            {
                Orders = await _context.Orders.ToListAsync();
            }
        }
    }
}
