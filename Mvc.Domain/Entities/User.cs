using Mvc.Domain.Common;
using Mvc.Domain.Entities.IdentityEntities;
namespace Mvc.Domain.Entities;
public class User : BaseAuditableEntity
{
    public string UserName { get; set; }
    public string Phone { get; set; }
    public string UserEmail { get; set; }
    public string Password { get; set; }
    public virtual ICollection<Role>? Roles { get; set; }
}
