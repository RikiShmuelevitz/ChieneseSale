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
    public class DonorService : IDonorService
    {
        public Task<DonorModel> AddAsync(DonorModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<List<DonorModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DonorModel> GetByIdAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<DonorModel> UpdateAsync(int id, DonorModel model)
        {
            throw new NotImplementedException();
        }
    }
}
