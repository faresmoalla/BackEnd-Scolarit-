﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainUser.Entities.JwtToken;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

using InfrastructureUser;
using Microsoft.AspNetCore.Authentication.JwtBearer;

using Microsoft.EntityFrameworkCore;

using Microsoft.IdentityModel.Tokens;

namespace InfrastructureUser;
public static class ConfigureService
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {


  

        return services;
    }
}
