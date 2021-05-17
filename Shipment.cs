namespace Facade_Pattern_Checkpoint
{
  public class Shipment
  {
    Address AddressToShip;
    Product ProductToShip;

    public Shipment(Address address, Product product) {
      AddressToShip = address;
      ProductToShip = product;
    }
  }
}