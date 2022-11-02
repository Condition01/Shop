using Shop.Domain.Entities;

namespace Shop.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public static List<Customer> Customers = new List<Customer>();

        public void Save(Customer customer)
        {
            Customers.Add(customer);
        }

        public Customer GetCustomerById(Guid id)
        {
            return Customers.Where(c => c.Id == id).First();
        }
    }
}
