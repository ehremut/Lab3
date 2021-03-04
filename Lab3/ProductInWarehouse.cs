using System.Collections.Generic;

namespace Lab3
{
    public class ProductInWarehouse
    {
        public int ProductInWarehouseId { get; set; }
        
        public Product Product { get; set; }
        
        public Warehouse Warehouse { get; set; }
        
        public int countOfProduct { get; set; }
    }
}