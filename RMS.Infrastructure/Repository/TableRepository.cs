using RMS.Application.Interfaces;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class TableRepository : GenericRepository<Table>, ITableRepository
    {
        public TableRepository(RMSDbContext context) : base(context)
        {
        }
    }
  
}
