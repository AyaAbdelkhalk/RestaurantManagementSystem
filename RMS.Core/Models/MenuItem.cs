using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class MenuItem : BaseEntity
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        //must be greater than 0
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        [Precision(18, 2)]
        public decimal UnitPrice { get; set; }
        public bool IsAvailable { get; set; }
        public int DailyOrderCount { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Preparation time must be greater than 0")]
        public int PreparationTimeInMinutes { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();


    }
}
