using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace buoi17_netcore.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Ten dang nhap khong de trong")]
        [DisplayName("Ten Dang Nhap")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mat khau khong de trong")]
        [DisplayName("Mat Khau")]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
