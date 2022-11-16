using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        [DisplayName("Sisplay Order")]
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
