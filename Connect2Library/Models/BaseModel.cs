using System;
using System.ComponentModel.DataAnnotations;

namespace Connect2Library.Models
{
    public abstract class BaseModel
    {
        public int CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastModifiedOn { get; set; }
    }
}