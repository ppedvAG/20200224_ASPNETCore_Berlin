using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationIndentitySample.Data;

[assembly: HostingStartup(typeof(WebApplicationIndentitySample.Areas.Identity.IdentityHostingStartup))]
namespace WebApplicationIndentitySample.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.Configure<IdentityOptions>(options =>
                {

                    // Default SignIn settings.
                    //Requires a confirmed email to sign in
                    options.SignIn.RequireConfirmedEmail = false;
                    //Requires a confirmed phone number to sign in
                    options.SignIn.RequireConfirmedPhoneNumber = false;


                    // Default User settings.
                    options.User.AllowedUserNameCharacters =
                            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                    options.User.RequireUniqueEmail = false;




                }); 
            });

        }
    }
}