/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using SWDemoToLearn2.Data.Database;
using SWDemoToLearn2.Domain.Services;
using SWDemoToLearn2.Interfaces.IServices;
using SWDemoToLearn2.Interfaces.IRepositories;
using SWDemoToLearn2.Infrastructure.Repositories;

namespace SWDemoToLearn2.Setup
{
    public static class StartupExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection _iServiceCollection)
        {
            #region Data
            _iServiceCollection.AddDbContext<BaseDbContext, FakeDbContext>(opt => opt.UseInMemoryDatabase(Guid.NewGuid().ToString()));
            #endregion

            #region Services
            _iServiceCollection.AddTransient<IOrderService, OrderService>();
            _iServiceCollection.AddTransient<IProductService, ProductService>();
            _iServiceCollection.AddTransient<ICustomerService, CustomerService>();
            #endregion

            #region AutoMapper
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles("SWDemoToLearn2" + ".Api", "SWDemoToLearn2" + ".Infrastructure");
            });
            #endregion

            #region Repositories
            _iServiceCollection.AddTransient<IOrderRepository, OrderRepository>();
            _iServiceCollection.AddTransient<IProductRepository, ProductRepository>();
            _iServiceCollection.AddTransient<ICustomerRepository, CustomerRepository>();
            #endregion

            return _iServiceCollection;
        }
    }
}
