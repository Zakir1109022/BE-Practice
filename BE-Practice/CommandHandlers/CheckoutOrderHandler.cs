using BE_Practice.Commands;
using BE_Practice.Entities;
using BE_Practice.Mapper;
using BE_Practice.Responses;
using BE_Practice.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BE_Practice.CommandHandlers
{
    public class CheckoutOrderHandler : IRequestHandler<CheckoutOrderCommand, OrderResponse>
    {
        private readonly IOrderService _orderService;

        public CheckoutOrderHandler(IOrderService orderService)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        public async Task<OrderResponse> Handle(CheckoutOrderCommand request, CancellationToken cancellationToken)
        {
            var orderEntity = OrderMapper.Mapper.Map<Order>(request);
            if (orderEntity == null)
                throw new ApplicationException($"Entity could not be mapped.");

             await _orderService.CreateAsync(orderEntity);

            var orderResponse = OrderMapper.Mapper.Map<OrderResponse>(orderEntity);
            return orderResponse;
        }
    }
}
