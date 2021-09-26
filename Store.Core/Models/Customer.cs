using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Models
{
    public class Customer : BaseModel
    {
        public string FirstName { get; set; }
        public string Surename { get; set; }
        public string Email { get; set; }
    }
}
