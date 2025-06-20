﻿using Microsoft.EntityFrameworkCore;
using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Models
{
    public class Order : BaseEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public virtual User? Customer { get; set; }
        //public DateTime? OrderTime { get; set; }
        public DateTime? DeliveryTime { get; set; } 
        public OrderStatus OrderStatus { get; set; }
        public OrderType OrderType { get; set; }
        [Precision(8, 4)]
        public decimal TaxPercentage { get; set; } = 0.085M;
        [Precision(8, 2)]
        public decimal DiscountAmount { get; set; }
        [Precision(8, 2)]
        public decimal TotalBeforeDiscounts { get; set; }
        [Precision(8, 2)]
        public decimal Total { get; set; }
        public string? Note { get; set; }
        public string? DeliveryAddress { get; set; }
        public virtual ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();

        //bonus
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
        public int? TableId { get; set; }
        public virtual Table? Table { get; set; }

        public string? AssignedStaffId { get; set; } // Staff
        public virtual User? AssignedStaff { get; set; }




        //public decimal CalculateDiscounts() 
        //{
        //    decimal discount = 0;
        //    if (OrderTime.HasValue && OrderTime.Value.Hour >= 15 && OrderTime.Value.Hour < 17)
        //    {
        //        discount += 0.20M * (OrderItems?.Sum(item => item.Subtotal) ?? 0); // 20%
        //    }
        //    if (OrderItems != null && OrderItems.Sum(item => item.Subtotal) > 100)
        //    {
        //        discount += 0.10M * (OrderItems.Sum(item => item.Subtotal)); // 10%
        //    }
        //    return discount;

        //}

    }
}
