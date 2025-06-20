using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Interfaces;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly RMSDbContext _context;
        protected readonly DbSet<T> _dbSet;
        private readonly ICurrentUserService _currentUserService;

        public GenericRepository(RMSDbContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            _currentUserService = currentUserService;
        }
        public async Task<T> AddAsync(T entity)
        {
            if (entity is IBaseEntity baseEntity)
            {
                baseEntity.CreatedAt = DateTime.UtcNow;
                baseEntity.CreatedBy = _currentUserService.GetCurrentUserId();
                baseEntity.IsDeleted = false; 
            }
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            //soft delete
            var entity = await _dbSet.FindAsync(id);
            if (entity is IBaseEntity baseEntity)
            {
                baseEntity.IsDeleted = true;
                baseEntity.DeletedAt = DateTime.UtcNow;
                baseEntity.DeletedBy = _currentUserService.GetCurrentUserId();
            }
            else
            {
                _dbSet.Remove(entity);
            }
            await _context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<T> GetAllAsync()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
             return await _dbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity is IBaseEntity baseEntity)
            {
                var userId = _currentUserService.GetCurrentUserId();
                baseEntity.UpdatedBy = userId;
                baseEntity.UpdatedAt = DateTime.UtcNow;
            }
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
