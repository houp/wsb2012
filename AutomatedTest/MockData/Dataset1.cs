using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using linq_class.Entities;

namespace AutomatedTest.MockData
{
    public class Dataset1
    {
        public Context DataContext { get; private set; }

        public Client GetClient(int id)
        {
            return DataContext.Clients.Where(c => c.Id == id).FirstOrDefault();
        }

        public Product GetProduct(int id)
        {
            return DataContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public Dataset1()
        {
            DataContext = new Context()
            {
                Clients = new List<Client>
                {
                    new Client {Id = 1, Email = "ja@hope.art.pl", Name = "Witold Bolt"},
                    new Client {Id = 2, Email = "jan@kowalski.pl", Name = "Jan Kowalski"},
                    new Client {Id = 3, Email = "julia@nowak.com", Name = "Julia Maria Nowak"},
                    new Client {Id = 4, Email = "billg@microsoft.com", Name = "Bill Gates"},
                    new Client {Id = 5, Email = "someone@somewhere.org", Name = "Unknown Person"}
                },

                Products = new List<Product>
                {
                    new Product { Id = 1, Name = "Pencil", Price = 2, Supplier = "Argo"},
                    new Product { Id = 2, Name = "iPad 2", Price = 1099, Supplier = "Apple"},
                    new Product { Id = 3, Name = "Beer", Price = 5, Supplier = "Lech"},
                    new Product { Id = 4, Name = "Ball", Price = 11, Supplier = "Nike"}
                }
            };

            IList<Order> orders = new List<Order> { 
                new Order {Id = 1, UnitPrice = 1.75m, Item = GetProduct(1), Quantity = 5, Buyer = GetClient(1), Date = new DateTime(2012, 2, 1) },
                new Order {Id = 4, UnitPrice = 1.81m, Item = GetProduct(1), Quantity = 13, Buyer = GetClient(3), Date = new DateTime(2012, 2, 8) },
                new Order {Id = 5, UnitPrice = 1.82m, Item = GetProduct(1), Quantity = 22, Buyer = GetClient(2), Date = new DateTime(2012, 2, 9) },
                new Order {Id = 6, UnitPrice = 1.83m, Item = GetProduct(1), Quantity = 2, Buyer = GetClient(2), Date = new DateTime(2012, 2, 10) },
                new Order {Id = 7, UnitPrice = 1.84m, Item = GetProduct(1), Quantity = 7, Buyer = GetClient(1), Date = new DateTime(2012, 2, 11) },
                new Order {Id = 8, UnitPrice = 2.02m, Item = GetProduct(1), Quantity = 1, Buyer = GetClient(1), Date = new DateTime(2012, 2, 16) },

                new Order {Id = 9, UnitPrice = 999m, Item = GetProduct(2), Quantity = 1, Buyer = GetClient(1), Date = new DateTime(2012, 1, 1) },
                new Order {Id = 10, UnitPrice = 999m, Item = GetProduct(2), Quantity = 2, Buyer = GetClient(2), Date = new DateTime(2012, 1, 5) },
                new Order {Id = 11, UnitPrice = 999m, Item = GetProduct(2), Quantity = 1, Buyer = GetClient(3), Date = new DateTime(2012, 1, 8) },
                new Order {Id = 12, UnitPrice = 999m, Item = GetProduct(2), Quantity = 200, Buyer = GetClient(4), Date = new DateTime(2012, 1, 8) },
                
                new Order {Id = 17, UnitPrice = 4.5m, Item = GetProduct(3), Quantity = 10, Buyer = GetClient(1), Date = new DateTime(2012, 2, 4) },
                new Order {Id = 18, UnitPrice = 4.5m, Item = GetProduct(3), Quantity = 8, Buyer = GetClient(2), Date = new DateTime(2012, 2, 4) },
                new Order {Id = 19, UnitPrice = 4.5m, Item = GetProduct(3), Quantity = 12, Buyer = GetClient(3), Date = new DateTime(2012, 2, 4) },
                new Order {Id = 20, UnitPrice = 4.75m, Item = GetProduct(3), Quantity = 30, Buyer = GetClient(4), Date = new DateTime(2012, 2, 11) },
                new Order {Id = 21, UnitPrice = 4.75m, Item = GetProduct(3), Quantity = 31, Buyer = GetClient(2), Date = new DateTime(2012, 2, 11) },
                new Order {Id = 22, UnitPrice = 5m, Item = GetProduct(3), Quantity = 12, Buyer = GetClient(2), Date = new DateTime(2012, 2, 18) },
                new Order {Id = 23, UnitPrice = 5m, Item = GetProduct(3), Quantity = 20, Buyer = GetClient(1), Date = new DateTime(2012, 2, 18) },
                new Order {Id = 24, UnitPrice = 5m, Item = GetProduct(3), Quantity = 3, Buyer = GetClient(5), Date = new DateTime(2012, 2, 18) },
            
                new Order {Id = 25, UnitPrice = 11m, Item = GetProduct(4), Quantity = 1, Buyer = GetClient(2), Date = new DateTime(2012, 2, 3) },
                new Order {Id = 28, UnitPrice = 11m, Item = GetProduct(4), Quantity = 1, Buyer = GetClient(5), Date = new DateTime(2012, 2, 5) },
                new Order {Id = 29, UnitPrice = 11m, Item = GetProduct(4), Quantity = 1, Buyer = GetClient(1), Date = new DateTime(2012, 2, 5) },
                new Order {Id = 30, UnitPrice = 11m, Item = GetProduct(4), Quantity = 1, Buyer = GetClient(3), Date = new DateTime(2012, 2, 12) },
                new Order {Id = 31, UnitPrice = 11m, Item = GetProduct(4), Quantity = 1, Buyer = GetClient(3), Date = new DateTime(2012, 2, 12) },
                new Order {Id = 32, UnitPrice = 11m, Item = GetProduct(4), Quantity = 1, Buyer = GetClient(1), Date = new DateTime(2012, 2, 19) }
            };

            DataContext.Orders = orders;

            foreach (Client c in DataContext.Clients)
            {
                c.Orders = DataContext.Orders.Where(o => o.Buyer == c).ToList();
            }

        }
    }
}
