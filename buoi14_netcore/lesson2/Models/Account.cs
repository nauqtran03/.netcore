using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lesson2.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name = "Họ và tên"),
            Required(ErrorMessage = "Tên không được để trống"),
            MinLength(6, ErrorMessage = "Họ tên ít nhất 6 kí tự"),
            MaxLength(20, ErrorMessage = "Họ tên tối đa 20 kí tự"),
        ]
        public string FullName { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+?\d{1,4}?[-. ]?\(?\d{1,3}?\)?[-. ]?\d{1,4}[-. ]?\d{1,4}[-. ]?\d{1,9}$", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage ="Địa chỉ không được bỏ trống")]
        [StringLength(35,ErrorMessage ="Địa chỉ không được vượt quá 35 kí tự")]
        public string Address { get; set; }
        [Display(Name ="Ảnh đại diện")]
        public string Avatar { get; set; }
        [Display(Name ="Ngày sinh")]
        [Required(ErrorMessage ="Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        [Display(Name = "Giới tính")]
        public int Gender {  get; set; }
        [Display(Name ="Mật khẩu")]
        [DataType (DataType.Password)]
        public string PassWord { get; set; }

        [Display(Name ="Link Face cá nhân")]
        [Required(ErrorMessage ="Link facebook không được để trống")]
        [Url(ErrorMessage ="Url phải đúng định dạng bao gồm http hoặc https")]
        public string FaceBook { get; set; }
    }
}
