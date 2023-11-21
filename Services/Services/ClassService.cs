using AutoMapper;
using Repository.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ClassService : IClassService
    {
        IClassRepository _rep;
        IMapper _mapper;
        public ClassService(IClassRepository repository, IMapper mapper)
        {
            _rep = repository;
            _mapper = mapper;
        }

        public async Task<ClassModel> AddAsync(ClassModel model)
        {
            return _mapper.Map<ClassModel>(await _rep.AddAsync(_mapper.Map<Class>(model)));
        }

        public async Task<List<ClassModel>> GetAllAsync()
        {
            List<ClassModel> classesToReturn=new List<ClassModel>();
            List<Class> classes = await _rep.GetAllAsync();
            foreach(Class item in classes) {
                classesToReturn.Add(_mapper.Map<ClassModel>(item));
            }
            return classesToReturn; 
        }

        public async Task<ClassModel> GetByIdAsync(int key)
        {
            return  _mapper.Map<ClassModel>(await _rep.GetByIdAsync(key));
        }

        public async Task<ClassModel> UpdateAsync(int id, ClassModel model )
        {
            return _mapper.Map<ClassModel>(await _rep.UpdateAsync(id,_mapper.Map<Class>(model)));
        }

        public async Task DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }
    }
}
