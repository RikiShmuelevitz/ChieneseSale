using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataSource : DbContext, IDataSource
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Student> Students { get; set; }




        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
