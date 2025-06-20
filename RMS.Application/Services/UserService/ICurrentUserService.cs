using RMS.Application.ViewModels.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.UserService
{
    public interface ICurrentUserService
    {
        public string? GetCurrentUserId();
        public Task<CurrentUserDetailsVM?> GetCurrentUserDetailsAsync();

    }
}
