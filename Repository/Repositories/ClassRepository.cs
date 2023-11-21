using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ClassRepository : IClassRepository
    {
        IDataSource _dataSource;

        public  ClassRepository(IDataSource dataSource)
        {
            _dataSource = dataSource;   
        }

        public async Task<List<Class>> GetAllAsync()
        {
           return await _dataSource.Classes.ToListAsync();
        }

        public async Task<Class> GetByIdAsync(int key)
        {
            return await _dataSource.Classes.FirstAsync(x => x.ClassId == key);
        }

        public async Task<Class> UpdateAsync(int id,Class entity)
        {
            Class tmp;
            tmp = await _dataSource.Classes.FirstAsync(e => e.ClassId == id);
            tmp.ClassAmount+= entity.ClassId;
            await _dataSource.SaveChangesAsync();
            return tmp;
        }
        public async Task<Class> AddAsync(Class entity)
        {
            _dataSource.Classes.Add(entity);
           await _dataSource.SaveChangesAsync();    
            return entity;
        }

        public Task DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }


    }
}
