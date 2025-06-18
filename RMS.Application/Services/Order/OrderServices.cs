using RMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.Order
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepository _orderRepository;
        public OrderServices(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

    }
}
