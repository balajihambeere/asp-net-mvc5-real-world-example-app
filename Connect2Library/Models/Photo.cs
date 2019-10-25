using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public class Photo : BaseModel
    {
        [Required]
        public int PhotoID { get; set; }
        public string ImagePath { get; set; }
        public Byte[] Image { get; set; }
    }
}