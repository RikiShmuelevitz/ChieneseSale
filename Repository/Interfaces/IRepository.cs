using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(int id,T entity);
        Task DeleteAsync(int key);
        Task<T> GetByIdAsync(int key);
        Task<List<T>> GetAllAsync();
       

    }
}
