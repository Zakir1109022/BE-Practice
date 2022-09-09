using BE_Practice.Dtos;
using BE_Practice.Mapper;
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
    public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, OrderResponse>
    {
        private readonly IOrderService _orderService;

        public GetAllOrderHandler(IOrderService orderService)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        public async Task<OrderResponse> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            var results = await _orderService.GetAllAsync();

            var orderResponse = new OrderResponse();
            orderResponse.Orders = OrderMapper.Mapper.Map<IEnumerable<OrderDto>>(results);

            return orderResponse;
        }
    }
}
