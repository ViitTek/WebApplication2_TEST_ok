using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2_TEST.Models;

namespace WebApplication2_TEST.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<WebApplication2_TEST.Models.mOrders> Orders { get; set; }
    public DbSet<WebApplication2_TEST.Models.mCustomer> Customer { get; set; }
}