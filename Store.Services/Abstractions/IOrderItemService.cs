using Store.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Abstractions
{
    public interface IOrderItemService
    {
        void Add(OrderItem model);
        void Add(IEnumerable<OrderItem> models);
        void Delete(int id);
        OrderItem Get(int id);
        IEnumerable<OrderItem> GetAll();
        void Update(OrderItem model);
        void Update(IEnumerable<OrderItem> models);
    }
}
