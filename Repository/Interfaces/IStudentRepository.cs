using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        //Task<Student> AddAsync(Student entity);
        //Task<Student> UpdateAsync(int id, Student entity);
        //Task DeleteAsync(int key);
        //Task<Student> GetByIdAsync(int key);
        //Task<List<Student>> GetAllAsync();

    }
}
