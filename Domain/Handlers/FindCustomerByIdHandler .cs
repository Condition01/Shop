using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;
using Shop.Domain.Repositories;

namespace Shop.Domain.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public async Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest command, CancellationToken token)
        {
            var customer = _repository.GetCustomerById(command.Id);
            return new FindCustomerByIdResponse
            {
                Email = customer.Email,
                Id = customer.Id,
                Name = customer.Name
            };
        }
    }
}