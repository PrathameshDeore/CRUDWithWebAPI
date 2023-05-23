using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsumeAPI.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Student Name")]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
