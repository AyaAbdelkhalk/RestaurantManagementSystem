using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Repository
{
    public class CouponRepository : GenericRepository<Coupon>, ICouponRepository
    {
        private readonly ICurrentUserService _currentUserService;

        public CouponRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public async Task<int> IsValid(int id)
        {
            var coupon = await _dbSet.FindAsync(id);
            if (coupon == null) return 0;
            if (coupon.IsDeleted) return 0;
            if (coupon.ExpirationDate < DateTime.UtcNow) return 0;
            return 1;
        }

        public async Task<Coupon?> SearchByCodeAsync(string couponCode)
        {
            if (string.IsNullOrEmpty(couponCode)) return null;
            var coupon = await _dbSet.FirstOrDefaultAsync(c => c.Code == couponCode && !c.IsDeleted && c.ExpirationDate > DateTime.UtcNow);
            return coupon;
        }
    }
}
