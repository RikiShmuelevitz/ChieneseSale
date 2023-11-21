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
    public class DonationService : IDonationService
    {
        IDonationRepository _rep;
        IMapper _mapper;

        public DonationService(IDonationRepository rep, IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }   
        public async Task<DonationModel> AddAsync(DonationModel model)
        {
            return _mapper.Map<DonationModel>(await _rep.AddAsync(_mapper.Map<Donation>(model)));
        }

        public async Task DeleteAsync(int key)
        {
            await _rep.DeleteAsync(key);
        }

        public async Task<List<DonationModel>> GetAllAsync()
        {
            List<DonationModel> ListToReturn= new List<DonationModel>();
            List<Donation> donations = await _rep.GetAllAsync();
            foreach (Donation donation in donations) {
                ListToReturn.Add(_mapper.Map<DonationModel>(donation));
            }
            return ListToReturn;
        }

        public async Task<DonationModel> GetByIdAsync(int key)
        {
            return _mapper.Map<DonationModel>(await _rep.GetByIdAsync(key));
        }

        public async Task<DonationModel> UpdateAsync(int id, DonationModel model)
        {
            return _mapper.Map<DonationModel>(await _rep.UpdateAsync(id, _mapper.Map<Donation>(model)));
        }
    }
}
