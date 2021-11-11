using System.ComponentModel.DataAnnotations;

namespace e_advert.web.Models.Accounts
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(8, ErrorMessage = "Password must be atleast six character long..!")]
        [Display(Name = "Password")]

        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password as it's confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}