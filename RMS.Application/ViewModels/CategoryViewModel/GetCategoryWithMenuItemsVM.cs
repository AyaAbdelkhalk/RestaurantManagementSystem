using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.ViewModels.CategoryViewModel
{
    public class GetCategoryWithMenuItemsVM
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public List<string> MenuItems { get; set; } = new List<string>(); // Assuming MenuItems is a list of strings, adjust as necessary
    }
}
