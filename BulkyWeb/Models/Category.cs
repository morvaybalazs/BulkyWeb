using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } // Removed '?' to make it non-nullable
        public int DisplayOrder { get; set; }
    }
}

