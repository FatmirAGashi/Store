using Store.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Abstractions
{
    public interface IProductService
    {
        void Add(Product model);
        void Add(IEnumerable<Product> models);
        void Delete(int id);
        Product Get(int id);
        IEnumerable<Product> GetAll();
        void Update(Product model);
        void Update(IEnumerable<Product> models);
    }
}
