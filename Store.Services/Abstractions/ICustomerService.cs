using Store.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Abstractions
{
    public interface ICustomerService
    {
        void Add(Customer model);
        void Add(IEnumerable<Customer> models);
        void Delete(int id);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
        void Update(Customer model);
        void Update(IEnumerable<Customer> models);
    }
}
