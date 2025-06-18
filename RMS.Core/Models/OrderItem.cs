using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class OrderItem : BaseEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        [Range(0.01, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Precision(8, 2)]
        public decimal UnitPrice { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public decimal Subtotal => UnitPrice * Quantity;
    }
}
