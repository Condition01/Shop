using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Handlers;
using Shop.Domain.Queries.Requests;

namespace Shop.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetById(
            [FromQuery] FindCustomerByIdRequest command)
        {
            var result = _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create(
            [FromBody] CreateCustomerRequest command)
        {
            var result = _mediator.Send(command);
            return Ok(result);
        }
    }
}