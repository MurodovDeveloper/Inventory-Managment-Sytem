using Microsoft.EntityFrameworkCore;
using Mvc.Domain.Entities;
using Mvc.Domain.Entities.IdentityEntities;

namespace Mvc.Application.Abstraction;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<ProductCategory> ProductCategories { get; set; }
    DbSet<Role> Roles { get; set; }
    DbSet<Permission> Permissions { get; set; }
    public int SaveChanges(bool acceptAllChangesOnSuccess);
}
