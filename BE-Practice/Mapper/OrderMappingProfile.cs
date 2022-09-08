using AutoMapper;
using BE_Practice.Commands;
using BE_Practice.Entities;
using BE_Practice.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Mapper
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, OrderResponse>().ReverseMap();
        }
    }
}
