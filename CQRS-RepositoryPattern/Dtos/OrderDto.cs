using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Dtos
{
    public class OrderDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public string EmailAddress { get; set; }
    }
}
