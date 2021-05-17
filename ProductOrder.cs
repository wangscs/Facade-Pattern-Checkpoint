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
            seedInventory();
        }

        public void seedInventory()
        {
            Product chair = new Product("chair", 8.99, 4);
            Product table = new Product("Table", 54.99, 1);
            inventoryService.Add(chair);
            inventoryService.Add(table);
        }

        public Shipment Purchase(
          string itemName, double itemCost, int itemQuantity,
          string cardNum, string cardDate, string cardSEC,
          string streetName, string city, string state, string zip)
        {
            Product purchasedItem = new Product(itemName, itemCost, itemQuantity);
            Payment payment = new Payment { CardNumber = cardNum, CardDate = cardDate, CardSecCode = cardSEC };
            Address address = new Address { Street = streetName, City = city, State = state, ZipCode = zip };

            //add payment to pending payments
            paymentService.Add(payment);

            //if payment approved then update inventory and remove pending payment
            paymentService.Substract(payment);
            inventoryService.Substract(new Product("chair", 8.99, 4));
            inventoryService.Add(new Product("chair", 8.99, 3));

            //then ship item
            Shipment ship = new Shipment(address, purchasedItem);
            shippingService.Add(ship);

            //when shipped remove pending shipment and return shipment receipt
            shippingService.Substract(ship);
            
            ship.Display();
            return ship;
        }
    }
}
