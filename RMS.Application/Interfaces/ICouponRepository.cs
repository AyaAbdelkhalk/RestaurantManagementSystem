﻿using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Interfaces
{
    public interface ICouponRepository : IGenericRepository<Coupon>
    {
        public Task<int> IsValid(int id);
        public Task<Coupon?> SearchByCodeAsync(string couponCode);
    }
}
