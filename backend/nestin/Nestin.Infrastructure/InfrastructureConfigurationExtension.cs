﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;
using Nestin.Infrastructure.Services;
using Nestin.Infrastructure.Shared;
using OpenAI;
using OpenAI.Chat;
using Stripe;
using System.Text;

namespace Nestin.Infrastructure
{
    public static class InfrastructureConfigurationExtension
    {
        public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Logging service
            services.AddLogging();

            services.AddDbContext<AppDbContext>(options
                    => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 12;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedAccount = false;
            }).AddEntityFrameworkStores<AppDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = false, // TODO: Turnned in prod environment
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audiance"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SigningKey"]))
                };

                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = ctx =>
                    {
                        ctx.Request.Cookies.TryGetValue("access_token", out var accessToken);


                        if (!string.IsNullOrEmpty(accessToken))
                        {
                            ctx.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });

            // OpenAI configuration
            services.AddHttpClient();
            services.Configure<OpenAIClientOptions>(configuration.GetSection("OpenAI"));
            services.AddKeyedSingleton<ChatClient>("MainOpenAIClient", (provider, key) =>
            {
                var apiKey = configuration["OpenAI:ApiKey"];
                var chatModel = configuration["OpenAI:ChatModel"];
                var client = new ChatClient(chatModel, apiKey);
                return client;
            });


            // Stripe Configurations
            services.AddSingleton<StripeClient>(new StripeClient(configuration["Stripe:SecretApiKey"]));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IIdentityFactory, IdentityFactory>();
            services.AddScoped<IFileStorageService, FileStorageService>();
            services.AddScoped<IServiceFactory, ServiceFactory>();

            return services;
        }
    }
}
