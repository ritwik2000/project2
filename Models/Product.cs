﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CrudApp.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}