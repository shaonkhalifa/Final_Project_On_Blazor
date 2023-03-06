using BlazorProject.Server.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Server.Data;

public class BlazorProjectServerContext : IdentityDbContext<ApplicationsUser>
{
    //public BlazorProjectServerContext(DbContextOptions<BlazorProjectServerContext> options)
    //    : base(options)
    //{
    //}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
