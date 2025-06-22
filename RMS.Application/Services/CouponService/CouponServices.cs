using Mapster;
using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
using RMS.Application.ViewModels.CouponViewModel;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.CouponService
{
    public class CouponServices : ICouponServices
    {
        private readonly ICouponRepository _couponRepository;
        public CouponServices(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        public async Task<AddCouponVM> CreateCouponAsync(AddCouponVM coupon)
        {
            var mappedCoupon = coupon.Adapt<Coupon>();
            await _couponRepository.AddAsync(mappedCoupon);
            return coupon;
        }
        public async Task<List<GetCouponVM>> GetAllCouponsAsync()
        {
            var coupons = await _couponRepository.GetAllAsync().ToListAsync();
            List<GetCouponVM> result = new List<GetCouponVM>();
            foreach (var coupon in coupons)
            {
                var mappedCoupon = coupon.Adapt<GetCouponVM>();
                result.Add(mappedCoupon);
            }
            return result;
        }
        public async Task<GetCouponVM> GetCouponByIdAsync(int id)
        {
            var coupon = await _couponRepository.GetByIdAsync(id);
            if (coupon == null) return null;
            
            return coupon.Adapt<GetCouponVM>();
        }

        public async Task<UpdateCouponVM> UpdateCouponAsync(int id, UpdateCouponVM couponvm)
        {
            var existingCoupon = await _couponRepository.GetByIdAsync(id);
            if (existingCoupon == null) return null;
            existingCoupon.Code = couponvm.CouponCode;
            existingCoupon.DiscountAmount = couponvm.DiscountAmount;
            existingCoupon.ExpirationDate = couponvm.ExpirationDate;
            existingCoupon.IsActive = couponvm.IsActive;
            existingCoupon.DiscountPercentage = couponvm.DiscountPercentage;

            await _couponRepository.UpdateAsync(existingCoupon);
            return couponvm;
        }
        public async Task<bool> DeleteCouponAsync(int id)
        {
            var coupon = await _couponRepository.GetByIdAsync(id);
            if (coupon == null) return false;
            await _couponRepository.DeleteAsync(id);
            return true;
        }

        public async Task<bool> IsCouponValidAsync(string couponCode)
        {
            var coupon = _couponRepository.SearchByCodeAsync(couponCode);
            var res=await _couponRepository.IsValid(coupon.Id);
            if (res == 1) return true;
            return false;

        }

        public Task<Coupon?> SearchByCodeAsync(string couponCode)
        {
            if (string.IsNullOrEmpty(couponCode)) return Task.FromResult<Coupon?>(null);
            return _couponRepository.SearchByCodeAsync(couponCode);
        }
    }
}
