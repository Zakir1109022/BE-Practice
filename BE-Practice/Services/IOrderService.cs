using BE_Practice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Services
{
   public interface IOrderService
    {
        Task<Order> GetByUserNameAsync(string user_name);
        Task CreateAsync(Order order);
    }
}
