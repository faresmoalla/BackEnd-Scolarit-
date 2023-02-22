using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities;
public  class Utilisateur : IdentityUser
{
    public int  IdUtilisateur{ get; set; }
    public string? Email { get; set; }

    public string? Password { get; set; }

   

}
