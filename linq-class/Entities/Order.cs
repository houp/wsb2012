using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq_class.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Product Item { get; set; }
        public Client Buyer { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get { return Quantity * UnitPrice; } }
        public DateTime Date { get; set; }

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
            Order p = obj as Order;
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
            return string.Format("Order Id: {0}; {1}; {2}; Order Price: {3}", Id, Buyer, Item, Price);
        }
        #endregion
    }
}
