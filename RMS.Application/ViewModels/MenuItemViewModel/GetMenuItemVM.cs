using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.MenuItemViewModel
{
    public class GetMenuItemVM
    {
        public int? MenuItemId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal UnitPrice { get; set; }
        public int PreparationTime { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }

    }
}
