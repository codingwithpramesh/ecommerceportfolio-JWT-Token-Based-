using Microsoft.AspNetCore.Identity;

namespace ecommerceportfolio.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }

        public string? ProfileImage { get; set; }
    }
}
