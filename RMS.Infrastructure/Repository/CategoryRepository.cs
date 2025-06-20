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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ICurrentUserService _currentUserService;

        public CategoryRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public async Task<List<Category>> SearchAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                var allCategories = GetAllAsync();
                return await allCategories.ToListAsync();
            }
            return await _context.Categories
                .Where(c => c.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToListAsync();
        }
    }
}
