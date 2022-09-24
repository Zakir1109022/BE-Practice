using BE_Practice.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderResponse>
    {
        public string Id { get; set; }

        public GetOrderByIdQuery(string id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }
    }
}
