using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSIP_App.Areas.Identity.Data;
using MSIP_App.Data;

[assembly: HostingStartup(typeof(MSIP_App.Areas.Identity.IdentityHostingStartup))]
namespace MSIP_App.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MSIPDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MSIPDbContextConnection")));

                services.AddDefaultIdentity<MSIPUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<MSIPDbContext>();
            });
        }
    }
}