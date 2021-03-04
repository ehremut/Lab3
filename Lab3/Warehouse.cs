using System.Collections.Generic;

namespace Lab3
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        
        public List<ProductInWarehouse> ProductInWarehouse { get; set; }
    }
}