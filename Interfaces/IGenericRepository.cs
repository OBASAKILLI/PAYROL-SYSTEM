using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Interfaces
{
    public interface IGenericRepository<T> where T : class

    {
        Task AddNew(T entity);  //Add
        Task<List<T>> GetAll();   //Get All
        Task<T> GetById(string Id);  //Get By Id
        Task Remove(T entity);  //remove
        Task Update(T entity);    //Update

    }
}
