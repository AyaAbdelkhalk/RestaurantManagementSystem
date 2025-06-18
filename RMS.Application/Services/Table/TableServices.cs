using RMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.Table
{
    public class TableServices : ITableServices
    {
        private readonly ITableRepository _tableRepository;
        public TableServices(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
    }
}
