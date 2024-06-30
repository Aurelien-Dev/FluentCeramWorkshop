using CeramWorkshop.Client.DataIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CeramWorkshop.Client.DataIdentity;

public class ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : IdentityDbContext<Workshop>(options)
{
    public DbSet<Workshop> Workshops { get; set; }
}
