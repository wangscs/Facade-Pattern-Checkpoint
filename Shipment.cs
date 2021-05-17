using System;

namespace Facade_Pattern_Checkpoint
{
  public class Shipment
  {
    public Address AddressToShip;
    public Product ProductToShip;

    public Shipment(Address address, Product product) {
      AddressToShip = address;
      ProductToShip = product;
    }

    public void Display() {
      Console.WriteLine($"Shipping {ProductToShip.Quantity}x - {ProductToShip.Name}, Cost: {ProductToShip.Price}");
      Console.WriteLine($"To: {AddressToShip.Street}, {AddressToShip.City}, {AddressToShip.State} {AddressToShip.ZipCode}");
    }
  }
}