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
        public string CouponCode { get; set; } = string.Empty;
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; } = true;
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; } = 0.00m;
    }
}
