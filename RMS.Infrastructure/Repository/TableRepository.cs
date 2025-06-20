using Microsoft.EntityFrameworkCore.Infrastructure;
using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class TableRepository : GenericRepository<Table>, ITableRepository
    {
        private readonly ICurrentUserService _currentUserService;
        public TableRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }
    }
  
}
