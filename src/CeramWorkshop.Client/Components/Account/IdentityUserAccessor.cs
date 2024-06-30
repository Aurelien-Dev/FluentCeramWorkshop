using CeramWorkshop.Client.DataIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace CeramWorkshop.Client.Components.Account;

internal sealed class IdentityUserAccessor(UserManager<Workshop> userManager, IdentityRedirectManager redirectManager)
{
    public async Task<Workshop> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        if (user is null)
        {
            redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
        }

        return user;
    }
}
