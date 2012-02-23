using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq_class.Entities
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Supplier { get; set; }

        public decimal Price { get; set; }

        #region Standard overrides

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            Product p = obj as Product;
            if (p == null) return false;

            return p.Id == Id;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Product Id: {0}, Name: {1}, Supplier: {2}, Price: {3}", Id, Name, Supplier, Price);
        }
        #endregion
    }
}
