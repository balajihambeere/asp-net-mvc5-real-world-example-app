using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public class Category : BaseModel
    {
        [Required]
        public int CategoryID { get; set; }

        [Required]
        [Display(Name = "Category name")]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        public string Name { get; set; }
    }
}