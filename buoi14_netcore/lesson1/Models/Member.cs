using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lesson1.Models
{
    public class Member
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("UserName")]
        [Required (ErrorMessage = "UserName không được để trống")]
        [StringLength(20,MinimumLength =3, ErrorMessage ="UserName có độ đai từ 3-20 kí tự")]
        public string UserName { get; set; }
        [DisplayName("FullName")]
        [Required(ErrorMessage = "FullName không được để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "FullName có độ đai từ 3-20 kí tự")]
        public string FullName {  get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        
        public string Email { get; set; }
        [DisplayName("Tên UserName")]
        [Required(ErrorMessage = "UserName không được để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "UserName có độ đai từ 3-20 kí tự")]
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        
    }
}
