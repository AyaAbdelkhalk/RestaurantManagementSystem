using RMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Core.Models;
using RMS.Application.ViewModels.CategoryViewModel;

namespace RMS.Application.Services.CategoryService
{
    public interface ICategoryServices
    {
        Task<List<GetCategoryDetailsVM>> GetAllCategoriesAsync();
        Task<GetCategoryDetailsVM> GetCategoryByIdAsync(int id);
        Task<GetCategoryDetailsVM> CreateCategoryAsync(AddCategoryVM category);
        Task<GetCategoryDetailsVM> UpdateCategoryAsync(AddCategoryVM category);
        Task<bool> DeleteCategoryAsync(int id);
        Task<List<GetCategoryDetailsVM>> SearchCategoriesAsync(string searchTerm);

    }
}
