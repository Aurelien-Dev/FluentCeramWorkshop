using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CeramWorkshop.Client.DataIdentity;

public class DataIdentityDbContext(DbContextOptions<DataIdentityDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{ }
