using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public class Supplier : BaseModel
    {
        [Required]
        public int SupplierID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Supplier name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Supplier Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Supplier Contact Number")]
        public string Contact { get; set; }

        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Supplier Email Address")]
        public string Email { get; set; }
    }
}