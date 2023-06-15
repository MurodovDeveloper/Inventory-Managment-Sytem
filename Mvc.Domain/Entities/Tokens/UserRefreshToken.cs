using Mvc.Domain.Common;

namespace Mvc.Domain.Entities.Tokens;

public class UserRefreshToken : BaseEntity
{
    public string Phone { get; set; }
    public string RefreshToken { get; set; }

    public DateTimeOffset AccessTokenExpiredDateTime { get; set; }
    public DateTimeOffset RefreshTokenExpiredDateTime { get; set; }
}
