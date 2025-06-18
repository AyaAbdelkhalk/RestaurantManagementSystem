using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; } 
        public bool IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public virtual User? CreatedByUser { get; set; }
        public int? UpdatedBy { get; set; }
        public virtual User? UpdatedByUser { get; set; }
        public int? DeletedBy { get; set; }
        public virtual User? DeletedByUser { get; set; }
        //// askkkkkk
        //[Timestamp]
        //public byte[] RowVersion { get; set; }



        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
            UpdatedAt = null;
            DeletedAt = null;
        }


    }
}
