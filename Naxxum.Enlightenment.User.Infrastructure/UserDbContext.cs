using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Naxxum.Enlightenment.User.Domain;

namespace Naxxum.Enlightenment.User.Infrastructure;

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
