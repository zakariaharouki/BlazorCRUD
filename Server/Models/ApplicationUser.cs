using Microsoft.AspNetCore.Identity;

namespace BlazorTask.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}