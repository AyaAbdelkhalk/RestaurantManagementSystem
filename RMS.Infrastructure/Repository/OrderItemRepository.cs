using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        private readonly ICurrentUserService _currentUserService;
        public OrderItemRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }

    }
  
}
