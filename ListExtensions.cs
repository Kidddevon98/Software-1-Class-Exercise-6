using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStore
{
    /// <summary>
    /// Provides extension methods for lists of products.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Filters a list of products to only include those that are in stock.
        /// </summary>
        /// <typeparam name="T">A type that inherits from the Product class.</typeparam>
        /// <param name="list">The list of products to filter.</param>
        /// <returns>A new list containing only the products that are in stock (Quantity > 0).</returns>
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(x => x.Quantity > 0).ToList();
        }
    }
}
