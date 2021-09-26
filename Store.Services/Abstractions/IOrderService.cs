using Store.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Abstractions
{
    public interface IOrderService
    {
        void Add(Order model);
        void Add(IEnumerable<Order> models);
        void Delete(int id);
        Order Get(int id);
        IEnumerable<Order> GetAll();
        void Update(Order model);
        void Update(IEnumerable<Order> models);
    }
}
