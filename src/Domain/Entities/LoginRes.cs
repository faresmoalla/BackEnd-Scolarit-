using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class LoginRes
{

    public string? UserName { get; set; }
    public string? Token { get; set; }
}
