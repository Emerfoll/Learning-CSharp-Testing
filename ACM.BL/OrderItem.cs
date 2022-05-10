using System;
namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasedPrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve order item.
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // retrieve ordered item code

            return new OrderItem();
        }

        /// <summary>
        /// Saves the current order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves defined order item

            return true;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasedPrice == null) isValid = false;

            return isValid;
        }

    }
}
