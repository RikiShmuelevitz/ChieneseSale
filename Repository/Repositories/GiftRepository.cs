using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GiftRepository : IGiftRepository
    {
        public Task<Gift> AddAsync(Gift entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<List<Gift>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Gift> GetByIdAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<Gift> UpdateAsync(int id, Gift entity)
        {
            throw new NotImplementedException();
        }
    }
}
