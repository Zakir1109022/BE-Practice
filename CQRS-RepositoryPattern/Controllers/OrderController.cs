﻿using BE_Practice.Commands;
using BE_Practice.Entities;
using BE_Practice.Queries;
using BE_Practice.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BE_Practice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [Route("[action]")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<OrderResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllOrderQuery();
            var orderList = await _mediator.Send(query);
            return Ok(orderList);
        }

        [HttpGet]
        [ProducesResponseType(typeof(OrderResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<OrderResponse>> GetOrderById(string Id)
        {
            var query = new GetOrderByIdQuery(Id);
            var order = await _mediator.Send(query);
            return Ok(order);
        }

        [HttpPost]
        [ProducesResponseType(typeof(OrderResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CheckoutOrder([FromBody] CreateOrderCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
