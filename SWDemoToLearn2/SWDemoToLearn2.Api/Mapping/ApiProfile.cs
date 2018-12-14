/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using AutoMapper;

using SWDemoToLearn2.Api.ViewModels.Order;
using SWDemoToLearn2.Api.ViewModels.Product;
using SWDemoToLearn2.Api.ViewModels.Customer;

using SWDemoToLearn2.Models;

namespace SWDemoToLearn2.Api.Mapping
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<OrderViewModel, OrderModel>().ReverseMap();
            CreateMap<ProductViewModel, ProductModel>().ReverseMap();
            CreateMap<CustomerViewModel, CustomerModel>().ReverseMap();
        }
    }
}
