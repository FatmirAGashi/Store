using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.EntityFramework.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
