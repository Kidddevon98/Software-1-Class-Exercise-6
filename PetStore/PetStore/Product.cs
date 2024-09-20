using System;

namespace PetStore
{
    /// <summary>
    /// Represents a generic product in the pet store.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the name of the product. Cannot be null.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the quantity of the product in stock.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets a description of the product. Cannot be null.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
