using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        IDataSource _dataSource;
        public StudentRepository(IDataSource dataSource)
        {
                _dataSource= dataSource;
        }
        public async Task<Student> AddAsync(Student entity)
        {
            _dataSource.Students.Add(entity);
            await _dataSource.SaveChangesAsync();   
            return entity;  
        }

        public async Task DeleteAsync(int key)
        {

            _dataSource.Students.Remove(
                _dataSource.Students.ToList().First(e => e.StudentId == key));
            await _dataSource.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _dataSource.Students.ToListAsync();

        }

        public  async Task<Student> GetByIdAsync(int key)
        {
            return await _dataSource.Students.FirstAsync(x => x.StudentId == key);
        }

        public async Task<Student> UpdateAsync(int id, Student entity)
        {
            Student tmp;
            tmp = await _dataSource.Students.FirstAsync(e => e.StudentId == id);
            tmp.StudentAmount = entity.StudentAmount;

            await _dataSource.SaveChangesAsync();
            return tmp;

        }
    }
}
