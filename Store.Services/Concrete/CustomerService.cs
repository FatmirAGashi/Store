using Store.Core.Models;
using Store.Repository.Abstractions;
using Store.Repository.EntityFramework.Entities;
using Store.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        public CustomerService(IRepository<CustomerEntity> customerRepository)
        {

        }
        public void Add(Customer model)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<Customer> models)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer model)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Customer> models)
        {
            throw new NotImplementedException();
        }
    }
}
