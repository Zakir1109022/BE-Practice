using BE_Practice.Commands;
using BE_Practice.Dtos;
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
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, OrderResponse>
    {
        private readonly IOrderService _orderService;

        public CreateOrderHandler(IOrderService orderService)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        public async Task<OrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            var order = new Order() {
                Id = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                EmailAddress=request.EmailAddress
            };

             await _orderService.CreateAsync(order);

            List<OrderDto> orderDtoList = new List<OrderDto>();
            var orderDto = OrderMapper.Mapper.Map<OrderDto>(order);
            orderDtoList.Add(orderDto);

            OrderResponse response = new OrderResponse();
            response.Orders = orderDtoList;

            return response;
        }
    }
}
