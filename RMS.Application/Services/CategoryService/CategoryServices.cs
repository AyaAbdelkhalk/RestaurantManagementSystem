using Mapster;
using RMS.Application.Interfaces;
using RMS.Application.Services.CategoryService;
using RMS.Application.ViewModels.CategoryViewModel;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.CategoryService
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryServices(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        //generic repository methods
        public async Task<List<GetCategoryDetailsVM>> GetAllCategoriesAsync()
        {
            var categories = _categoryRepository.GetAllAsync();
            List<GetCategoryDetailsVM> result = new List<GetCategoryDetailsVM>();
            foreach (var category in categories) {
                var mappedCategory = category.Adapt<GetCategoryDetailsVM>();
                result.Add(mappedCategory);
            }
            return result;
        }
        public async Task<GetCategoryDetailsVM> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null) return null;
            return category.Adapt<GetCategoryDetailsVM>();
        }
        public async Task<GetCategoryDetailsVM> CreateCategoryAsync(AddCategoryVM category)
        {
            var mappedCategory = category.Adapt<Category>();
            var createdCategory = await _categoryRepository.AddAsync(mappedCategory);
            return createdCategory.Adapt<GetCategoryDetailsVM>();
        }
        public async Task<GetCategoryDetailsVM> UpdateCategoryAsync(AddCategoryVM category)
        {
            var mappedCategory = category.Adapt<Category>();
            var updatedCategory = await _categoryRepository.UpdateAsync(mappedCategory);
            return updatedCategory.Adapt<GetCategoryDetailsVM>();
        }
        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null) return false;
            await _categoryRepository.DeleteAsync(id);
            return true;
        }
        public async Task<List<GetCategoryDetailsVM>> SearchCategoriesAsync(string searchTerm)
        {
            var categories = await _categoryRepository.SearchAsync(searchTerm);
            List<GetCategoryDetailsVM> result = new List<GetCategoryDetailsVM>();
            foreach (var category in categories) {
                var mappedCategory = category.Adapt<GetCategoryDetailsVM>();
                result.Add(mappedCategory);
            }
            return result;
        }
    }
}
