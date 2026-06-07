using System.ComponentModel.DataAnnotations;

namespace QuizWebsite.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Just give me an email it's not hard")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Just give me a password it's not hard")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be between {2} and {1} characters")]
        [DataType(DataType.Password)]
        [Compare("ConfirmNewPassword", ErrorMessage = "Did you already forget what you typed?? smh")]
        [Display(Name = "Password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Just give me the same password as before it's not hard")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string ConfirmNewPassword { get; set; }
    }
}
