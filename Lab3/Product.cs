using System;
using System.Collections.Generic;

namespace Lab3
{
    public class Product
    {
        public int ProductId { get; set; }
        
        public string Name { get; set; }

       // public List<ProductSeller> ProductSeller { get; set; }
        
        public List<ProductInWarehouse> ProductInWarehouse { get; set; }
        
        public int startPrice { get; set; }
        
        public int endPrice { get; set; }
    }
}