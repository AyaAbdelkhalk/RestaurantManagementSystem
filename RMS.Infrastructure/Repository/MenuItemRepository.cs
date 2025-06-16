using RMS.Application.Interfaces;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(RMSDbContext context) : base(context)
        {
        }
    }
  
}
