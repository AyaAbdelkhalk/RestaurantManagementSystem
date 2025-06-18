using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
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
        public GenericRepository(RMSDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            //soft delete
            var entity = await _dbSet.FindAsync(id);
            var baseEntity = entity as BaseEntity;
            if (baseEntity != null)
            {
                baseEntity.IsDeleted = true;
                baseEntity.DeletedAt = DateTime.UtcNow;
                //_dbSet.Update(baseEntity);
                //ملهاش لازمه عشان الفايند لما بتجيب انتيتي بتبقى تراكد ف بيتسمع من السيف اتشينزيز 
            }
            else
            {
                _dbSet.Remove(entity);
            }
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
             return await _dbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
