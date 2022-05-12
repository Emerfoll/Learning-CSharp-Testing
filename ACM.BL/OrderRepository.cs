using System;
namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Create instance of the order class
            // pass requested ID
            Order order = new Order(orderId);

            // code to retrieve defined order

            // temp hard coded values to return

            if (orderId == 10)
            {
                // use current year in hard coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;

        }

        /// <summary>
        /// Saves current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // code to save order

            return true;
        }
    }
}
