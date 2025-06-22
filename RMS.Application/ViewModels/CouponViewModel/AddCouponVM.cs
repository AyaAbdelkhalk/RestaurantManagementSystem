using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.CouponViewModel
{
    [Index(nameof(CouponCode), IsUnique = true)]
    public class AddCouponVM
    {


        [Required(ErrorMessage = "Coupon code is required")]
        public string CouponCode { get; set; }

        [Range(0.01, 100.00)]
        public decimal? DiscountPercentage { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? DiscountAmount { get; set; }

        public bool IsActive { get; set; }

        public DateTime? ExpirationDate { get; set; }
    }
}
