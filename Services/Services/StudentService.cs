using AutoMapper;
using Services.Interfaces;
using Services.Models;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class StudentService : IStudentService
    {
         IStudentRepository _rep;
         IMapper _mapper;
        public StudentService(IStudentRepository rep, IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }
    
        public async Task<StudentModel> AddAsync(StudentModel model)
        {
            return _mapper.Map<StudentModel>(await _rep.AddAsync(_mapper.Map<Student>(model))); 
        }

        public async Task DeleteAsync(int key)
        {
            await _rep.DeleteAsync(key);
        }

        public async Task<List<StudentModel>> GetAllAsync()
        {
            List<StudentModel> ListToReturn= new List<StudentModel>();
            List<Student> students = await _rep.GetAllAsync();
            foreach (Student student in students)
            {
                ListToReturn.Add(_mapper.Map<StudentModel>(student));
            }
            return ListToReturn;
        }

        public async Task<StudentModel> GetByIdAsync(int key)
        {
            return _mapper.Map<StudentModel>(await _rep.GetByIdAsync(key));
        }

        public async Task<StudentModel> UpdateAsync(int id,StudentModel model)
        {
            return _mapper.Map<StudentModel>(await _rep.UpdateAsync(id,_mapper.Map<Student>(model)));
        }
    }
}
