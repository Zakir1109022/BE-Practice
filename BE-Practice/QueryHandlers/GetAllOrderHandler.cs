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
    public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, OrderResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public GetAllOrderHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<OrderResponse> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            var results = await _orderService.GetAllAsync();

            var orderResponse = new OrderResponse() { 
                Orders= _mapper.Map<IEnumerable<OrderDto>>(results)
            };

            return orderResponse;
        }
    }
}
