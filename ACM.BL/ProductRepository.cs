using System;
namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Create instance of the product class
            // pass requested ID
            Product product = new Product(productId);

            // code to retrieve defined product

            // temp hard coded values to return

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 yellow mini sunflowers.";
                product.CurrentPrice = 15.96M;
            }
            return product;

        }

        /// <summary>
        /// Saves current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // code to save product

            return true;
        }
    }
}
