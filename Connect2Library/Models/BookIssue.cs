using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Connect2Library.Models
{
    public class BookIssue : BaseModel
    {
        [Required]
        public int BookIssueID { get; set; }

        [Required]
        [Display(Name = "Book Code")]
        public string BookCode { get; set; }

        [Required]
        [Display(Name = "Date Issued")]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Required]
        [Display(Name = "Date Issued")]
        [DataType(DataType.DateTime)]
        public DateTime DateReturn { get; set; }

        [Required]
        [Display(Name = "Date Returned")]
        [DataType(DataType.DateTime)]
        public DateTime DateReturned { get; set; }

        [Required]
        [Display(Name = "Book Issued Status")]
        public bool BookIssuedStatus { get; set; }

        [Required]
        [Display(Name = "Book Issued Status")]
        public string FineRange { get; set; }
    }
}