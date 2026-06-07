using Microsoft.AspNetCore.Identity;

namespace QuizWebsite.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
