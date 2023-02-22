
using CleanArchitecture.Domain.Entities;
using IdentityModel;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;


namespace CleanArchitecture.WebUI.Services

{
    public class Utils
    {
        public string CreateJwt(Utilisateur User, bool RemembreMe)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("startupkitjwttoken"));
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name,User.UserName),
                new Claim(ClaimTypes.NameIdentifier, User.Id)
            };
            var signingCredentials = new SigningCredentials(
                key, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = RemembreMe ? DateTime.UtcNow.AddDays(7) : DateTime.UtcNow.AddDays(1),
                SigningCredentials = signingCredentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
    }
}
