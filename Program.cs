using System;

namespace Facade_Pattern_Checkpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductOrder store = new ProductOrder();
            var receipt = store.Purchase(
                "chair",
                8.99,
                1,
                "12345",
                "12/2020",
                "001",
                "23 Road lane",
                "Houston",
                "Texas",
                "23094"
            );
        }
    }
}
