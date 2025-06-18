using RMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.MenuItem
{
    public class MenuItemServices : IMenuItemServices
    {
        private readonly IMenuItemRepository _menuItemRepository;
        public MenuItemServices(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }
    }
}
