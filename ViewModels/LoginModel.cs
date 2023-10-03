using System.ComponentModel.DataAnnotations;

namespace Authenrification_Authorization.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email didnt define")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password didnt define")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
