using Warehouse.Domain.Entities;

namespace Warehouse.Domain.Repository;

public class InMemoryRepository
{
    private static List<Product> products = new List<Product>();
    
    public IList<Product> GetProducts() => products;
    public Product GetProdut(Guid id) => products.Where(p => p.Id == id).First();
    public void AddProduct(Product product) => products.Add(product);
    public bool DeleteProduct(Guid id) => products.Remove(products.Where(p => p.Id == id).First());
}