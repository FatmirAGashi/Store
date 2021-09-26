﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.EntityFramework.Entities
{
    public class CustomerEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
