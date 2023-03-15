using Microsoft.AspNetCore.Identity;

namespace Naxxum.Enlightenment.User.Domain
{
    // This interface is responsible for generating a new jwt token
    public interface IJwtTokenGenerator
    {
        string GenerateToken(IdentityUser user);
    }
}
