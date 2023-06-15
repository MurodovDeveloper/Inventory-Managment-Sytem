using Mvc.Domain.Common;
namespace Mvc.Domain.Entities;
public class ProductCategory : BaseAuditableEntity
{
    public string CategoryName { get; set; }
}
