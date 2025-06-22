using RMS.Application.ViewModels.OrderItemViewModel;
using RMS.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.OrderViewModel
{
    public class AddOrderVM : IValidatableObject
    {
        [Required]
        public OrderType OrderType { get; set; }

        public int? TableId { get; set; } // For dine-in

        public string? DeliveryAddress { get; set; } // For delivery

        public string? Note { get; set; }

        public int? CouponId { get; set; }

        public string? CouponCode { get; set; }

        [Required(ErrorMessage = "Please add at least one item.")]
        public List<AddOrderItemVM> OrderItems { get; set; } = new();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (OrderType == OrderType.Delivery && string.IsNullOrWhiteSpace(DeliveryAddress))
            {
                yield return new ValidationResult(
                    "Delivery address is required for delivery orders.",
                    new[] { nameof(DeliveryAddress) });
            }
        }
    }

}
