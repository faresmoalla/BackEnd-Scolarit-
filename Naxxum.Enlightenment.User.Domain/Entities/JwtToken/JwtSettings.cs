using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.Enlightenment.User.Domain;
public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public string Secret { get; init; } = null!;
    public int ExpiryMinutes { get; init; }
    public string Issuer { get; set; } = null!;
    public string Audience { get; set; } = null!;
}
