using BE_Practice.Dtos;
using BE_Practice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Responses
{
    public class OrderResponse
    {
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}
