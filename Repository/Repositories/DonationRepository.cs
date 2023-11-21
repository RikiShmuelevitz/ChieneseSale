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
    public class DonationRepository : IDonationRepository
    {
        IDataSource _dataSource;

        public DonationRepository(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public async Task<Donation> AddAsync(Donation entity)
        {
            _dataSource.Donations.Add(entity);
            await _dataSource.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int key)
        {
            _dataSource.Donations.Remove(
               _dataSource.Donations.ToList().First(e => e.DonationId == key));
            await _dataSource.SaveChangesAsync();
        }

        public async Task<List<Donation>> GetAllAsync()
        {
            return await _dataSource.Donations.ToListAsync();
        }

        public async Task<Donation> GetByIdAsync(int key)
        {
            return await _dataSource.Donations.FirstAsync(x => x.DonationId == key);
        }

        public Task<Donation> UpdateAsync(int id, Donation entity)
        {
   
            throw new NotImplementedException();
        }



    }
}
