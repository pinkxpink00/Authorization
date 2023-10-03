using System.ComponentModel.DataAnnotations;
namespace Authenrification_Authorization.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "didnt define Email...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "didnt define Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password")]
        public string ConfirmPassword { get; set; }
    }
}
