using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.Database
{
    [Table("Publishers")]
    public class Publisher
    {
        [Display(Name = "Mã nhà xuất bản")]
        public int PublisherId { get; set; }

        [Display(Name = "Tên nhà xuất bản")]
        [StringLength(100)]
        public string PublisherName { get; set; }

        [Display(Name = "Địa chỉ")]
        [StringLength(200)]
        public string Address { get; set; }

        // Quan hệ 1-N với Book
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
