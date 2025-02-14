using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.Database
{
    [Table("Categories")]
    public class Category
    {
        [Display(Name = "Mã loại")]
        public int CategoryId { get; set; }

        [Display(Name = "Tên loại")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        // Quan hệ 1-N với Book
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
