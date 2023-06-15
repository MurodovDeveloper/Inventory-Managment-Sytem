using Mvc.Domain.Common;

namespace Mvc.Domain.Entities;

public class Product : BaseAuditableEntity
{
    public string ProductName { get; set; } 
    public Guid CategoryId { get; set; }
    public ProductCategory Category { get; set; }
    public decimal? Price { get; set; }
}
