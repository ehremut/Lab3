using System;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            
            context.Database.EnsureDeleted();
            
            context.Database.EnsureCreated();
            
            context.Dispose();
        }

        private static void SqlReauests(int sellerId, int price, int productId)
        {
            string connectionString = "Server=localhost,1433;Database=Lab3;User=sa;Password=P@55w0rd;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                string sql1 = String.Format($"select * from ProductSeller where ProductId = {sellerId}");
                command.CommandText = sql1;
                command.Connection = connection;
                
                string sql2 = String.Format($"select * from Product where endPrice < {price}");
                command.CommandText = sql2;
                command.Connection = connection;
                
                string sql3 = String.Format($"select countOfProduct from ProductInWarehouse where ProductId = {productId}");
                command.CommandText = sql3;
                command.Connection = connection;
            }
        }

        private static void FindProducts(Context context, int sellerId)
        {
            IQueryable<ProductSeller> products = from product in context.ProductSellers
                where (product.Seller.SellerId == sellerId)
                select product;
        }
        
        private static void FindProductsInPrice(Context context, int price)
        {
            IQueryable<Product> products = from product in context.Products
                where (product.endPrice < price )
                select product;
        }
        
        private static void FindProductsCount(Context context, int productId)
        {
            IQueryable<int> countProductInWarehouses = from productInWarehouse in context.ProductInWarehouses
                where (productInWarehouse.Product.ProductId == productId)
                select productInWarehouse.countOfProduct;
        }
    }
}