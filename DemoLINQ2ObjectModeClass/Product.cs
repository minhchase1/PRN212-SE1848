﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ2ObjectModeClass
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Quantity}\t{Price}";
        }
        public Product Clone()
        {
            return MemberwiseClone() as Product;
        }
    }
}
