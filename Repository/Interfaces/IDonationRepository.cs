using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDonationRepository : IRepository<Donation>
    {
        //Task<Donation> AddAsync(Donation entity);
        //Task<Donation> UpdateAsync(int id, Donation entity);
        //Task DeleteAsync(int key);
        //Task<Donation> GetByIdAsync(int key);
        //Task<List<Donation>> GetAllAsync();
    }
}
