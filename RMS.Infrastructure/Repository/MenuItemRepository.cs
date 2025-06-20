using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
    {
        private readonly ICurrentUserService _currentUserService;

        public MenuItemRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }
    }
  
}
