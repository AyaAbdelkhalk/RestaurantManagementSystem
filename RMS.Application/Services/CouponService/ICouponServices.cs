using RMS.Application.ViewModels.CouponViewModel;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.CouponService
{
    public interface ICouponServices
    {
        Task<List<GetCouponVM>> GetAllCouponsAsync();
        Task<GetCouponVM> GetCouponByIdAsync(int id);
        Task<AddCouponVM> CreateCouponAsync(AddCouponVM coupon);
        Task<UpdateCouponVM?> UpdateCouponAsync(int id, UpdateCouponVM coupon);
        Task<bool> DeleteCouponAsync(int id);

        //not in generic repository
        Task<bool> IsCouponValidAsync(string couponCode);
        Task<Coupon?> SearchByCodeAsync(string couponCode);



        //Task<bool> IsCouponValidAsync(string couponCode, decimal orderTotal);
        //Task<decimal> GetDiscountAmountAsync(string couponCode, decimal orderTotal);
        //Task<bool> ApplyCouponAsync(string couponCode, decimal orderTotal);
        //Task<bool> RemoveCouponAsync(string couponCode);
        //Task<List<string>> GetAvailableCouponsAsync();
    }
}
