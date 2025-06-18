using RMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.Coupon
{
    public class CouponServices : ICouponServices
    {
        private readonly ICouponRepository _couponRepository;
        public CouponServices(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }
    }
}
