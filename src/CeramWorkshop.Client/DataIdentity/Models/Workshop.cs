using Microsoft.AspNetCore.Identity;

namespace CeramWorkshop.Client.DataIdentity.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class Workshop : IdentityUser
{
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string WorkshopName { get; set; }

    public string GetInitials()
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(LastName))
        {
            return string.Empty;
        }

        return $"{char.ToUpper(Name[0])}{char.ToUpper(LastName[0])}";
    }

}
