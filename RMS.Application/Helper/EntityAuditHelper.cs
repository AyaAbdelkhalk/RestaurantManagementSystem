using RMS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Helper
{
    public static class EntityAuditHelper
    {
        public static void SetCreatedBy(this IBaseEntity entity, string userId)
        {
            entity.CreatedBy = userId;
            entity.CreatedAt = DateTime.UtcNow;
        }
        public static void SetUpdatedBy(this IBaseEntity entity, string userId)
        {
            entity.UpdatedBy = userId;
            entity.UpdatedAt = DateTime.UtcNow;
        }
        public static void SetDeletedBy(this IBaseEntity entity, string userId)
        {
            entity.DeletedBy = userId;
            entity.DeletedAt = DateTime.UtcNow;
            entity.IsDeleted = true;
        }
    }
}
