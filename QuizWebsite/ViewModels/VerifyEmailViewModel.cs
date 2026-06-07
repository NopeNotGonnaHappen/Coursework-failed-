using System.ComponentModel.DataAnnotations;

namespace QuizWebsite.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Just give me an email it's not hard")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
