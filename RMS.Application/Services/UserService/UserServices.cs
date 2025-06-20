using Mapster;
using Microsoft.AspNetCore.Identity;
using RMS.Application.Interfaces;
using RMS.Application.ViewModels.UserViewModel;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.UserService
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


     
    }
}
