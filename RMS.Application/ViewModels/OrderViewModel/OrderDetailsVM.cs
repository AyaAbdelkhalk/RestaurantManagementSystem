using RMS.Application.ViewModels.OrderItemViewModel;
using RMS.Core.Enum;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.OrderViewModel
{
    public class OrderDetailsVM
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = "N/A";
        public string? Note { get; set; }
        public string? DeliveryAddress { get; set; }

        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public decimal TaxPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalBeforeDiscounts { get; set; }
        public decimal Total { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? DeliveryTime { get; set; }

        public int? TableId { get; set; }
        public int? TableNumber { get; set; }
        public int? CouponId { get; set; }
        public string? CouponCode { get; set; }

        public List<OrderItemVM> OrderItems { get; set; } = new();
    }
}
