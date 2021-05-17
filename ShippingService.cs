using System.Collections.Generic;

namespace Facade_Pattern_Checkpoint
{
    public class ShippingService
    {
    List<Shipment> ShipmentList = new List<Shipment>();

    public void Add(Shipment shipment)
    {
      ShipmentList.Add(shipment);
    }
    public void Substract(Shipment shipment)
    {
      ShipmentList.Remove(shipment);
    }
    }
}