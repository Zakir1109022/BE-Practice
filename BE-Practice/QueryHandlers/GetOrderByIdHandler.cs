using AutoMapper;
using BE_Practice.Dtos;
using BE_Practice.Queries;
using BE_Practice.Responses;
using BE_Practice.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BE_Practice.QueryHandlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public GetOrderByIdHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<OrderResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            List<OrderDto> orderDtoList = new List<OrderDto>();
            var order = await _orderService.GetByIdAsync(request.Id);

            var orderDto = _mapper.Map<OrderDto>(order);
            orderDtoList.Add(orderDto);

            OrderResponse response = new OrderResponse() {
                Orders = orderDtoList
            };
           

            return response;
        }
    }
}
