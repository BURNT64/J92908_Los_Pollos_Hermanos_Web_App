﻿using Los_Pollos_Hermanos_Web_App.Data;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Los_Pollos_Hermanos_Web_App.Data
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<ResturantContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AppDbContext")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
             .AddEntityFrameworkStores<ResturantContext>()
             .AddDefaultTokenProviders();
        }
    }
}
