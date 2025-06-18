using RMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.OrderItemService
{
    public class OrderItemServices : IOrderItemServices
    {
        private readonly IOrderItemRepository _orderItemRepository;
        public OrderItemServices(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
    }
}
