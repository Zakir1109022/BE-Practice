using AutoMapper;
using BE_Practice.Commands;
using BE_Practice.Dtos;
using BE_Practice.Entities;
using BE_Practice.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Mapper
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}
