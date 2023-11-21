using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IClassRepository:IRepository<Class>
    {
        //Task<Class> AddAsync(Class entity);
        //Task<Class> UpdateAsync(int id, Class entity);
   
        //Task<Class> GetByIdAsync(int key);
        //Task<List<Class>> GetAllAsync();
    }
}
