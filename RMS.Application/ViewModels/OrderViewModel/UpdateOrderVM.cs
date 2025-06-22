using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.OrderViewModel
{
    public class UpdateOrderVM
    {
        public int? OrderId { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        [Required]
        public OrderType OrderType { get; set; }

        public DateTime? DeliveryTime { get; set; }

        [StringLength(500)]
        public string? Note { get; set; }

        [StringLength(200)]
        public string? DeliveryAddress { get; set; }

        public int? CouponId { get; set; }
        public string? CouponCode { get; set; }

        public int? TableId { get; set; }

        public string? AssignedStaffId { get; set; }
    }
}
