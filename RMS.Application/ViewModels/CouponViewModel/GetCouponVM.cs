using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.CouponViewModel
{
    public class GetCouponVM
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; } = true;
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
    }
}
