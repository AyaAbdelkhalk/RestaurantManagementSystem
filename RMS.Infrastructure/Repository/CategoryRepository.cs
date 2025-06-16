using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
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
        public CategoryRepository(RMSDbContext context) : base(context)
        {

        }
        // get all categories with menu items
        
    }
}
