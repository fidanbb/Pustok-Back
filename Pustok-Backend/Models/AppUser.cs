using Microsoft.AspNetCore.Identity;

namespace Pustok_Backend.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsRememberMe { get; set; }
    }
}
