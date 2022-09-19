using AutoMapper;
using BE_Practice.Commands;
using BE_Practice.Dtos;
using BE_Practice.Entities;
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
        private readonly IMapper _mapper;

        public CreateOrderHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
            var orderDto = _mapper.Map<OrderDto>(order);
            orderDtoList.Add(orderDto);

            OrderResponse response = new OrderResponse() {
                Orders = orderDtoList
            };


            return response;
        }
    }
}
