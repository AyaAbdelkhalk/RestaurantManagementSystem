using RMS.Application.Interfaces;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(RMSDbContext context) : base(context)
        {
        }
    }
  
}
