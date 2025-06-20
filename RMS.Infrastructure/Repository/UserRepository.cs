using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ICurrentUserService _currentUserService;
        public UserRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }
    }

}
