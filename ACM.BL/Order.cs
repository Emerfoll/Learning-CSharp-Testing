using System;
namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // retrieve order code

            return new Order();
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves defined order

            return true;
        }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }




    }
}
