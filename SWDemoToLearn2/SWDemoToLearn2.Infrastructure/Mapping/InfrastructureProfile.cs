﻿/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using AutoMapper;

using SWDemoToLearn2.Models;
using SWDemoToLearn2.Data.Entities;

namespace SWDemoToLearn2.Infrastructure.Mapping
{
    public class InfrastructureProfile : Profile
    {
        public InfrastructureProfile()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap().ForMember(c => c.Orders, config => config.Ignore());
            CreateMap<Order, OrderModel>().ReverseMap().ForMember(o => o.OrderProducts, config => config.Ignore());
            CreateMap<Product, ProductModel>().ReverseMap().ForMember(p => p.OrderProducts, config => config.Ignore());
        }
    }
}
