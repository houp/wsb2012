using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using linq_class.Entities;

namespace linq_class.Services
{
    public class CustomerService : BaseService
    {
        public CustomerService(Context context) : base(context) { }  

        public Client GetClientById(int id)
        {
            return (from Client c in _context.Clients where c.Id == id select c).FirstOrDefault();
            // You can also use method syntax: return _context.Clients.Where(c => c.Id == id).FirstOrDefault();
        }

        public Client GetClientByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IList<Client> FindClientsWhoBought(Product product)
        {
            throw new NotImplementedException();
        }

        public IDictionary<Client, decimal> GetTotalPurchuseAmountsOfClients()
        {
            throw new NotImplementedException();
        }

        public IList<Client> GetClientsWithNoOrders()
        {
            throw new NotImplementedException();
        }

        public IList<Client> GetClientsWithAnyOrders()
        {
            throw new NotImplementedException();
        }

        public IList<Client> GetClientsWithOrdersOnGivenDay(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IList<Client> GetClientsWithMoreOrdersThanGivenClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
