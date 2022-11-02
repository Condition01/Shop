using Shop.Domain.Entities;

namespace Shop.Domain.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
        Customer GetCustomerById(Guid id);
    }
}
