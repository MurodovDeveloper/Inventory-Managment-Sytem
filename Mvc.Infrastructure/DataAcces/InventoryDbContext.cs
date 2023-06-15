using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mvc.Application.Abstraction;
using Mvc.Domain.Entities;
using Mvc.Domain.Entities.IdentityEntities;
namespace Mvc.Infrastructure.DataAcces;

public class InventoryDbContext : IdentityDbContext<IdentityUser>, IApplicationDbContext
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }
    public InventoryDbContext()
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    DbSet<User> IApplicationDbContext.Users { get; set; }
    DbSet<Role> IApplicationDbContext.Roles { get; set; }
}
