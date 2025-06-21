using Mapster;
using RMS.Application.ViewModels.CategoryViewModel;
using RMS.Application.ViewModels.CouponViewModel;
using RMS.Application.ViewModels.MenuItemViewModel;
using RMS.Application.ViewModels.UserViewModel;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Helper
{
    public class Mapper
    {
        public static void RegisterMapsterConfiguration()
        {
            // TypeAdapterConfig<s,T>

            #region AccountMapping

            //RegisterVM to User
            TypeAdapterConfig<RegisterVM, User>
                    .NewConfig()
                    .Map(dest => dest.UserName, src => src.UserName)
                    .Map(dest => dest.Email, src => src.Email)
                    .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                    .Map(dest => dest.Address, src => src.Address)
                    .TwoWays();
            //User to CurrentUserDetailsVM
            TypeAdapterConfig<User, CurrentUserDetailsVM>
                    .NewConfig()
                    .Map(dest => dest.UserId, src => src.Id)
                    .Map(dest => dest.UserName, src => src.UserName)
                    .Map(dest => dest.Email, src => src.Email)
                    .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                    .Map(dest => dest.Address, src => src.Address)
                    .TwoWays();

            #endregion

            #region CategoryMapping
            //Category to AddCategoryVM
            TypeAdapterConfig<Category, AddCategoryVM>
                    .NewConfig()
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.IsActive, src => src.IsActive)
                    .TwoWays();
            //Category to GetCategoryDetailsVM
            TypeAdapterConfig<Category, GetCategoryDetailsVM>
                    .NewConfig()
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.IsActive, src => src.IsActive)
                    .TwoWays();

            TypeAdapterConfig<GetCategoryDetailsVM, AddCategoryVM>
                    .NewConfig()
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.IsActive, src => src.IsActive)
                    .TwoWays();

            TypeAdapterConfig<Category, UpdateCategoryVM>
                    .NewConfig()
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.IsActive, src => src.IsActive)
                    .TwoWays();
            #endregion

            #region MenuItemMapping

            //MenuItem to AddMenuItemVM
            TypeAdapterConfig<MenuItem, AddMenuItemVM>
                    .NewConfig()
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.Price, src => src.UnitPrice)
                    .Map(dest => dest.Image, src => src.ImageUrl)
                    .Map(dest => dest.IsAvailable, src => src.IsAvailable)
                    .Map(dest => dest.CategoryId, src => src.CategoryId)
                    .Map(dest => dest.PreparationTime, src => src.PreparationTimeInMinutes)
                    .TwoWays();
            //MenuItem to GetMenuItemVM
            TypeAdapterConfig<MenuItem, GetMenuItemVM>
                    .NewConfig()
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.UnitPrice, src => src.UnitPrice)
                    .Map(dest => dest.ImageUrl, src => src.ImageUrl)
                    .Map(dest => dest.IsAvailable, src => src.IsAvailable)
                    .Map(dest => dest.CategoryId, src => src.CategoryId)
                    .Map(dest => dest.CategoryName, src => src.Category.Name)
                    .Map(dest => dest.PreparationTime, src => src.PreparationTimeInMinutes)
                    .TwoWays();

            //MenuItem to UpdateMenuItemVM
            TypeAdapterConfig<MenuItem, UpdateMenuItemVM>
                    .NewConfig()
                    .Map(dest => dest.MenuItemId, src => src.MenuItemId)
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.Price, src => src.UnitPrice)
                    .Map(dest => dest.Image, src => src.ImageUrl)
                    .Map(dest => dest.IsAvailable, src => src.IsAvailable)
                    .Map(dest => dest.CategoryId, src => src.CategoryId)
                    .Map(dest => dest.PreparationTime, src => src.PreparationTimeInMinutes)
                    .TwoWays();

            //GetMenuItemVM to UpdateMenuItemVM
            TypeAdapterConfig<GetMenuItemVM, UpdateMenuItemVM>
                    .NewConfig()
                    .Map(dest => dest.MenuItemId, src => src.MenuItemId)
                    .Map(dest => dest.Name, src => src.Name)
                    .Map(dest => dest.Description, src => src.Description)
                    .Map(dest => dest.Price, src => src.UnitPrice)
                    .Map(dest => dest.ImageUrl, src => src.ImageUrl)
                    .Map(dest => dest.IsAvailable, src => src.IsAvailable)
                    .Map(dest => dest.CategoryId, src => src.CategoryId)
                    .Map(dest => dest.PreparationTime, src => src.PreparationTime)
                    .TwoWays();

            #endregion

            #region CouponMapping

            //Coupon to AddCouponVM
            TypeAdapterConfig<Coupon, AddCouponVM>
                    .NewConfig()
                    .Map(dest => dest.CouponCode, src => src.Code)
                    .Map(dest => dest.DiscountAmount, src => src.DiscountAmount)
                    .Map(dest =>dest.DiscountPercentage, src => src.DiscountPercentage)
                    .Map(dest => dest.ExpirationDate, src => src.ExpirationDate)
                    .Map(dest => dest.IsActive, src => src.IsActive)
                    .TwoWays();
            TypeAdapterConfig<Coupon, GetCouponVM>
                    .NewConfig()
                    .Map(dest => dest.CouponCode, src => src.Code)
                    .Map(dest => dest.DiscountAmount, src => src.DiscountAmount)
                    .Map(dest => dest.DiscountPercentage, src => src.DiscountPercentage)
                    .Map(dest => dest.ExpirationDate, src => src.ExpirationDate)
                    .Map(dest => dest.IsActive, src => src.IsActive)
                    .TwoWays();

            #endregion

        }
    }
}
