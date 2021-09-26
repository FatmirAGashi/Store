using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Models
{
    public class OrderItem : BaseModel
    {
        public string Code { get; set; }
        public Product Product { get; set; }
    }
}
