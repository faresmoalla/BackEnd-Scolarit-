using Microsoft.AspNetCore.Identity;

namespace DomainUser.Entities.JwtToken
{
    // This interface is responsible for generating a new jwt token
    public interface IJwtTokenGenerator
    {
        string GenerateToken(IdentityUser user);
    }
}
