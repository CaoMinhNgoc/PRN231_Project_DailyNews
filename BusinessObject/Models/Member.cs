using Microsoft.AspNetCore.Identity;

namespace BusinessObject.Models
{
    public class Member : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Actice { get; set; }
    }
}
