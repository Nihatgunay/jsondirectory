namespace JSON;

public class Product
{
    private static int _idcounter = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public double CostPrice { get; set; }
    public double SalePrice { get; set; }
    
    public Product()
    {
        Id = _idcounter++;
    }
}
