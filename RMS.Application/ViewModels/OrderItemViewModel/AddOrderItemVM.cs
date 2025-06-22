using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.OrderItemViewModel
{
    public class AddOrderItemVM
    {
        public int MenuItemId { get; set; }

        [Range(1, 100, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }
    }
}
