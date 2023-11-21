using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Extentions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IDonationRepository, DonationRepository>();

            services.AddScoped<IDataSource, DataSource>();
            services.AddDbContext<DataSource>();

            MapperConfiguration _config=new MapperConfiguration(conf =>
            {
                conf.CreateMap<ClassModel, Class>().ReverseMap();
                conf.CreateMap<DonationModel, Donation>().ReverseMap();
                conf.CreateMap<StudentModel, Student>().ReverseMap();


            });

            IMapper mapper=_config.CreateMapper();
            services.AddSingleton(mapper);
                  

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }

    }
}
