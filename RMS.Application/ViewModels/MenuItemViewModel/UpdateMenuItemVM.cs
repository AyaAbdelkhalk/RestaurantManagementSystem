using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.MenuItemViewModel
{
    public class UpdateMenuItemVM
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsAvailable { get; set; } = true;
        [DataType(DataType.Upload)]
        public IFormFile? Image { get; set; }
        public string? ImageUrl { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Preparation time must be greater than 0.")]
        public int PreparationTime { get; set; }
    }
}
