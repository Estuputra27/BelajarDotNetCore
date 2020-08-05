using System;
using BelajarDotNetCore.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BelajarDotNetCore.Areas.Identity.IdentityHostingStartup))]
namespace BelajarDotNetCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BelajarDotNetCoreContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BelajarDotNetCoreContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<BelajarDotNetCoreContext>();
            });
        }
    }
}