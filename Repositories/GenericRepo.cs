using Microsoft.EntityFrameworkCore;
using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Repositories
{
    public class GenericRepo<T> : IGenericRepository<T> where T : class
    {
        public readonly AppDbContext _appDbContext;
      

        public GenericRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AddNew(T entity)
        {
           await _appDbContext.Set<T>().AddAsync(entity);
        }

        public async Task<List<T>> GetAll()
        {
           return await _appDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(string Id)
        {
         return   await _appDbContext.Set<T>().FindAsync(Id);        }

        public async Task Remove(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
        }

        public async Task Update(T entity)
        {
            _appDbContext.Set<T>().Update(entity);
        }
    }
}
