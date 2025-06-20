using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly ICurrentUserService _currentUserService;
        public OrderRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }
    }
  
}
