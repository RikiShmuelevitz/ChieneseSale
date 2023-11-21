using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDataSource
    {
        DbSet<Class> Classes { get; set; }
        DbSet<Donation> Donations { get; set; }
        DbSet<Donor> Donors { get; set; }
        DbSet<Gift> Gifts { get; set; }
        DbSet<Student> Students { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
