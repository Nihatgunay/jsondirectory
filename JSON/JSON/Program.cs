namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Lenovo\\Desktop\\";

            Directory.CreateDirectory(path + "Task\\");
            File.Create(path + "Task\\" + "example.txt");

            ProductService productservice = new ProductService();
            Product product1 = new Product() { Name = "Iphone 15", CostPrice = 1000, SalePrice = 2000 };
            Product product2 = new Product() { Name = "Iphone 16", CostPrice = 2000, SalePrice = 3000 };

             productservice.Create(product1);

            Product product = productservice.Get(1);
            Console.WriteLine(product);
        }
    }
}
