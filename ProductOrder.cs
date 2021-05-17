using System;

namespace Facade_Pattern_Checkpoint
{
    class ProductOrder
    {
        private InventoryService inventoryService;
        private PaymentService paymentService;
        private ShippingService shippingService;

        public ProductOrder(){
            inventoryService = new InventoryService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
        }
        
        
    }
}
