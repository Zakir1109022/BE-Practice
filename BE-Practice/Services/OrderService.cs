using BE_Practice.Entities;
using BE_Practice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Services
{
    public class OrderService: IOrderService
    {
        private readonly IRepository<Order> _repository;
        public OrderService(IRepository<Order> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Order> GetByUserNameAsync(string user_name)
        {
            return await _repository.GetById(user_name);
        }
        public async Task CreateAsync(Order order)
        {
            await _repository.Create(order);
        }
    }
}
