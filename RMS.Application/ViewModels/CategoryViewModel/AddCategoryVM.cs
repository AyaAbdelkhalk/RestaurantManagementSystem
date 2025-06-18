using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RMS.Application.ViewModels.CategoryViewModel
{
    public class AddCategoryVM
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public IFormFile? ImageFile { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
