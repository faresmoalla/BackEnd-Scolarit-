
using System.Collections.Generic;
using System.Reflection;
using DomainUser.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InfrastructureUser;

public class UserDbContext : IdentityDbContext<IdentityUser>
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
    }


    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        SeedDefaultUser.RegisterDefaultUser(builder);
        base.OnModelCreating(builder);
    }

  


}
