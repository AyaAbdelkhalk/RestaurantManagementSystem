using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class Category : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        //public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<MenuItem>? MenuItems { get; set; } = new List<MenuItem>();




    }
}
