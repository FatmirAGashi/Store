using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.EntityFramework.Entities
{
    public class OrderEntity : BaseEntity
    {
        public string Code { get; set; }
        public CustomerEntity Customer { get; set; }
        public ICollection<OrderItemEntity> OrderItems { get; set; }
    }
}
