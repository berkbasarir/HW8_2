﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW8_2
{
    public class Product
    {
        public int ProductId { get; set; } //Primary Key
        public int CategoryId { get; set; } //Foreign Key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}
