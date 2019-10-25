using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public class Role : BaseModel
    {
        [Required]
        public int RoleID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}