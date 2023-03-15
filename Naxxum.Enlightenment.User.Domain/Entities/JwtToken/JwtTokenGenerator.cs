using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Naxxum.Enlightenment.User.Domain
{
    // This is an implementation of IJwtTokenGenerator
    // This class is responsible for generating a new token
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtSettings _jwtSettings;
        
        // Constructor
        public JwtTokenGenerator(IOptions<JwtSettings> jwtOptions)
        {
            _jwtSettings = jwtOptions.Value;
        }

        // Generate token
        public string GenerateToken(IdentityUser user)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
                SecurityAlgorithms.HmacSha256);

            // Add claims
            // There are a lot of options like name, sub or etc. that we can add to the jwt token 
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Assing static information that exists inside the appsettings.json file
            var securityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                audience: _jwtSettings.Audience,
                claims: claims,
                signingCredentials: signingCredentials
                );
            // Write a token and pass it as result of the GenerateToken() method
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
