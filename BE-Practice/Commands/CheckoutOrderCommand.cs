using BE_Practice.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Commands
{
    public class CheckoutOrderCommand: IRequest<OrderResponse>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
