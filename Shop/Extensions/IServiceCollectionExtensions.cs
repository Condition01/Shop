using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Queries.Requests;
using System.Reflection;

namespace Shop.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddMediatRs(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCustomerRequest).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(FindCustomerByIdRequest).GetTypeInfo().Assembly);
        }
    }
}
