using System.Collections.Generic;

namespace Facade_Pattern_Checkpoint
{
  public class InventoryService
  {
    List<Product> productList = new List<Product>();

    public void Add(Product product)
    {
      productList.Add(product);
    }
    public void Substract(Product product)
    {
      productList.Remove(product);
    }
  }
}