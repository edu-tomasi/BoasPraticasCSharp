using System.Collections.Generic;

namespace PatternCommand_DiferentesAcoes
{
    public class Broker
    {
        private IList<Order> Orders = new List<Order>();

        public void takeOrder(Order order)
        {
            Orders.Add(order);
        }

        public void placeOrders()
        {
            foreach (Order orderItem in Orders)
            {
                orderItem.Execute();
            }

            Orders.Clear();
        }
    }
}
