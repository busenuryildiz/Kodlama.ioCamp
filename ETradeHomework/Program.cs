namespace ETradeHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductName = "Laptop";
            product1.Description = "256 gb SSD";
            product1.UnitPrice = 25000;
            
            Product product2 = new Product();
            product2.ProductName = "Mouse";
            product2.Description = "Bluetooth";
            product2.UnitPrice = 500;



            Product[] products = new Product[] { product1, product2 };


            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.Description + " : " + product.UnitPrice);
            }
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }
    }

}