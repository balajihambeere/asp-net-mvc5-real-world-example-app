using System;
using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public class Member : BaseModel
    {
        [Required]
        public int MemberID { get; set; }

        [Required]
        [Display(Name = "Member name")]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "City")]
        [StringLength(100, ErrorMessage = "The {0} Required.")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Register Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateRegister { get; set; }

        [Required]
        [Display(Name = "Register Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateExpire { get; set; }

        [Required]
        [Display(Name = "Member Ship Status")]
        public bool MemberShipStatus { get; set; }
    }
}