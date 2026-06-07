using System.ComponentModel.DataAnnotations;

namespace QuizWebsite.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Just give me an email it's not hard")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Just give me a password it's not hard")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
