//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace AuthorizeCustom_netcore.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email khong duoc de trong")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password khong duoc de trong")]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
