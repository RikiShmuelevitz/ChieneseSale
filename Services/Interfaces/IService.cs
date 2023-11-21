﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IService<T>
    {
        Task<T> AddAsync(T model);
        Task<T> UpdateAsync(int id, T model);
        Task DeleteAsync(int key);
        Task<T> GetByIdAsync(int key);
        Task<List<T>> GetAllAsync();
       

    }
}
