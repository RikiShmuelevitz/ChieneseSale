using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DonorRepository : IDonorRepository
    {
        public Task<Donor> AddAsync(Donor entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<List<Donor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Donor> GetByIdAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<Donor> UpdateAsync(int id, Donor entity)
        {
            throw new NotImplementedException();
        }
    }
}
