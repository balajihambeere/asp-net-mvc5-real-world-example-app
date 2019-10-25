using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public class User : BaseModel
    {
        [Required]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "User name")]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PassWord { get; set; }
    }
}