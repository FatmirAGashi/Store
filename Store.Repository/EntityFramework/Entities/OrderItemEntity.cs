using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.EntityFramework.Entities
{
    public class OrderItemEntity : BaseEntity
    {
        public string Code { get; set; }
        public ProductEntity ProductEntity { get; set; }
    }
}
