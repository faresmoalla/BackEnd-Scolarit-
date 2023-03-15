using System;
using System.Text;

using Naxxum.Enlightenment.User.Domain;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Naxxum.Enlightenment.User.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
// DB CONFIGURATION and DbContext


ConfigurationManager configuration = builder.Configuration;
builder.Services.AddDbContext<UserDbContext>
(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), p => p.MigrationsAssembly("User")));
builder.Services.AddCors();


//Cookie Policy needed for External Auth
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.Unspecified;
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = true;
    // After 5 request failed the account will be locked
    options.Lockout.MaxFailedAccessAttempts = 5;

    // After 5 minutes the account will be unlocked
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
}).AddEntityFrameworkStores<UserDbContext>().AddRoles<IdentityRole>().AddDefaultTokenProviders();

// Jwt Configuration
var jwtSettings = new JwtSettings();
builder.Configuration.Bind(JwtSettings.SectionName, jwtSettings);

builder.Services.AddSingleton(Options.Create(jwtSettings));

builder.Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
// configure bd

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(
    options => options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings.Issuer,
        ValidAudience = jwtSettings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwtSettings.Secret))
    });






///////// Migration automatique
/*using (var context = new UserDbContext())
{
    context.Database.Migrate();
}*/



var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
