﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; } //Northwind Database'in yapısına göre string veriyoruz.
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

    }
}