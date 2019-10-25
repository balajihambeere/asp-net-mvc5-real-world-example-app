using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public class Book : BaseModel
    {
        [Required]
        public int BookID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Book Code")]
        public string Code { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Book Titile")]
        public string Title { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Book Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "ISBN Number")]
        public string Isbn { get; set; }

        [Required]
        [Display(Name = "Number Of Pages")]
        public int NumberOfPages { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Book Edition")]
        public string Edition { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Book Author")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Book Price")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Book Publication")]
        public string Publication { get; set; }

        [Required]
        [Display(Name = "Book Publish Date")]
        public DateTime PublishDate { get; set; }

        [Required]
        [Display(Name = "Date Arrival")]
        public DateTime DateArrival { get; set; }

        [Required]
        [Display(Name = "Rack Number")]
        public int RackNumber { get; set; }

        [Required]
        public int SupplierID { get; set; }

        [Required]
        public int CategoryID { get; set; }
    }
}