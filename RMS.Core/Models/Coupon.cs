using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace RMS.Core.Models
{
    public class Coupon : BaseEntity
    {
        public int CouponId { get; set; }
        [Required(ErrorMessage = "Coupon code is required")]
        public string Code { get; set; }

        [Range(0.01, 100.00, ErrorMessage = "Discount percentage must be between 0.01 and 99.99")]
        [Precision(4, 2)]
        public decimal? DiscountPercentage { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Discount amount must be greater than 0")]
        [Precision(18, 2)]
        public decimal? DiscountAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public virtual ICollection<Order>? UsedInOrders { get; set; } = new List<Order>();
    }
}
