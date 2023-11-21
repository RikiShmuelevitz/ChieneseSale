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
    public class GiftService : IGiftService
    {
        public Task<GiftModel> AddAsync(GiftModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<List<GiftModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GiftModel> GetByIdAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<GiftModel> UpdateAsync(int id, GiftModel model)
        {
            throw new NotImplementedException();
        }
    }
}
