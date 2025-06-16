using RMS.Application.Interfaces;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(RMSDbContext context) : base(context)
        {
        }
    }
  
}
