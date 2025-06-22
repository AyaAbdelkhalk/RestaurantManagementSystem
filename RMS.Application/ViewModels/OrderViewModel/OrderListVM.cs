using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.OrderViewModel
{
    public class OrderListVM
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = "N/A";
        public OrderStatus OrderStatus { get; set; }
        public OrderType OrderType { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public int OrderItemsCount { get; set; }
    }
}
