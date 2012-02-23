using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using linq_class.Entities;

namespace linq_class.Services
{
    public class OrderService : BaseService
    {
        public OrderService(Context c) : base(c) { }

        public Order GetOrderWithHighestPrice()
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetOrdersWithPriceHigherThen(decimal price)
        {
            throw new NotImplementedException();
        }

        public IDictionary<DateTime, int> GetOrderCountPerDay()
        {
            throw new NotImplementedException();
        }

        public IDictionary<DayOfWeek, int> GetOrderTotalPerDayOfWeek() {
            throw new NotImplementedException();
        }

        public IList<Order> GetOrdersOfProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetOrdersOfClient(Client client)
        {
            throw new NotImplementedException();
        }

        public bool HaveCustomerBoughtProduct(Client client, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
