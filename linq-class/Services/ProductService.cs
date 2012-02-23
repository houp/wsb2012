using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using linq_class.Entities;

namespace linq_class.Services
{
    public class ProductService : BaseService
    {
        public ProductService(Context context) : base(context) { }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetMostFrequentlyBoughtProduct()
        {
            throw new NotImplementedException();
        }

        public bool CheckIfProductWasEverBought(Product product)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductsThatWereNeverBougth()
        {
            throw new NotImplementedException();
        }

        public Dictionary<DateTime, decimal> GetProductPriceHistoryFromOrders(Product product)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductsBoughtByCustomer(Client client)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductsBySupplier(string supplier)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, IList<Product>> GetProductsBySuppliers()
        {
            throw new NotImplementedException();
        }

    }
}
