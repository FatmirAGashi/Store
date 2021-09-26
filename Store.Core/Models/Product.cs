using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Models
{
    public class Product : BaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
