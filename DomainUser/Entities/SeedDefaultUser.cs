using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DomainUser.Entities;


public static class SeedDefaultUser
{
    public static void RegisterDefaultUser(ModelBuilder modelBuilder)
    {
        var user = UserInfo();
        var adminRole = RoleAdmin();
        var EtudiantRole = RoleEtudiant();
        var EnseignatRole = RoleEnseignant();
        var EmployéRole = RoleEmploye();
        var userRole = UserRole(user.Id, adminRole.Id);

        modelBuilder.Entity<IdentityUser>().HasData(user);
        modelBuilder.Entity<IdentityRole>().HasData(adminRole, EtudiantRole, EnseignatRole, EmployéRole);
        // User HasNoKey() since the userId and RoleId is a unique foreign key in a many-to-many relationship
        modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey().HasData(userRole);
    }
     
    // Add User
    private static IdentityUser UserInfo()
    {
        var user = new IdentityUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "admin@admin.com",
            EmailConfirmed = true,
            UserName = "admin@admin.com"
        };

        PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
        user.PasswordHash = hasher.HashPassword(user, "admin_1234");

        return user;
    }

    // Add Admin Role
    private static IdentityRole RoleAdmin()
    {

        var role = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "admin",
            NormalizedName = "Admin"
        };

        return role;
    }
    // Add Admin Role
    private static IdentityRole RoleEtudiant()
    {

        var role = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Etudiant",
            NormalizedName = "Etudiant"
        };

        return role;
    }
    private static IdentityRole RoleEnseignant()
    {

        var role = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Enseignant",
            NormalizedName = "Enseignant"
        };

        return role;
    }

    private static IdentityRole RoleEmploye()
    {

        var role = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Employé",
            NormalizedName = "Employé"
        };

        return role;
    }
    // Add User Role
    private static IdentityUserRole<string> UserRole(string userId, string roleId)
    {
        var userRole = new IdentityUserRole<string>
        {
            RoleId = roleId,
            UserId = userId
        };
        return userRole;
    }




}

