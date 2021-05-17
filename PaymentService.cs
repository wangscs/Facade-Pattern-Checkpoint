using System.Collections.Generic;

namespace Facade_Pattern_Checkpoint
{
    public class PaymentService
    {
    List<Payment> PaymentList = new List<Payment>();

    public void Add(Payment payment)
    {
      PaymentList.Add(payment);
    }
    public void Substract(Payment payment)
    {
      PaymentList.Remove(payment);
    }
    }
}