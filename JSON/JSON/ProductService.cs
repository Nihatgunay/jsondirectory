using System.Text.Json;

namespace JSON;

public class ProductService
{
    public List<Product> products = new List<Product>();
    string path2 = "C:\\Users\\Lenovo\\Desktop\\Task\\example.txt\\";

    public void Create(Product product)
    {
        products.Add(product);
        string productjson = JsonSerializer.Serialize(product);
        StreamWriter streamWriter = new StreamWriter(path2,true);
        streamWriter.Write(productjson);
        File.WriteAllText(path2, productjson);
    }
    public Product Get(int id)
    {
        return products.Find(x => x.Id == id);
    }
    public void Delete(int id)
    {
        Product? wantedproduct = products.Find(y => y.Id == id);
        if (wantedproduct != null)
        {
            products.Remove(wantedproduct);
            string productjson = JsonSerializer.Serialize(products);
            //File.WriteAllText(path2,productjson);
            File.Delete(path2);
        }
    }
    public List<Product> GetAll()
    {

        return new List<Product>();
    }

}
