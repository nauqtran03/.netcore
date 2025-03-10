using System.ComponentModel.DataAnnotations;

namespace buoi21_netcore.Models.DBModel
{
    public class Login
    {
        [Required(ErrorMessage = "UserName khong duoc de tron")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password khong duoc de tron")]
        public string Password { get; set; }
    }
}
