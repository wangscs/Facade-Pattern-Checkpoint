using System;

namespace Facade_Pattern_Checkpoint
{
  class ProductOrder
  {
    private InventoryService inventoryService;
    private PaymentService paymentService;
    private ShippingService shippingService;

    public ProductOrder()
    {
      inventoryService = new InventoryService();
      paymentService = new PaymentService();
      shippingService = new ShippingService();
    }

    public void createOrder()
    {
      Product chair = new Product("chair", 8.99, 4);
      Product table = new Product("Table", 54.99, 1);
      inventoryService.Add(chair);
      inventoryService.Add(table);



    }

  }
}
