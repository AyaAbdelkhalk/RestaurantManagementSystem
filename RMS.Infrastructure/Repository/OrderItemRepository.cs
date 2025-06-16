using RMS.Application.Interfaces;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(RMSDbContext context) : base(context)
        {
        }
    }
  
}
