namespace Facade_Pattern_Checkpoint
{
  public class Product
  {

    public Product(string name, double price, int quantity)
    {
      Name = name;
      Price = price;
      Quantity = quantity;
    }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
  }
}