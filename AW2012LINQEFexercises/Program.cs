using AW2012LINQEFexercises.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW2012LINQEFexercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAmountOfShopsPerCity();


            Console.WriteLine("finito");
            Console.ReadLine();
        }
        
        // 7. EF + LINQ – korzystaj z bazy AdventureWorks2012, wyświetl recenzje produktów – join!@
        private static void ShowProductsReviews()
        {
            using (AW2012Context DbContext = new AW2012Context())
            {
                var productsWithReview = from p in DbContext.Products
                                         join r in DbContext.ProductReviews
                                         on p.ProductID equals r.ProductID
                                         select new
                                         {
                                             ProductName = p.Name,
                                             Revision = r.Comments
                                         };

                foreach (var pr in productsWithReview)
                {
                    Console.WriteLine($"{pr.ProductName}" +
                        $"{Environment.NewLine}" +
                        $"{pr.Revision}" +
                        $"{Environment.NewLine}{Environment.NewLine}");

                }
            }
        }

        // 8. Wyświetl raport sprzedaży produktów używając LINQ (sprzedaż per produkt kiedykolwiek)

        private static void ShowProductsSalesEver()
        {
            using (AW2012Context DbContext = new AW2012Context())
            {
                var SoldProducts = from pr in DbContext.Products
                                   join sod in DbContext.SalesOrderDetails
                                   on pr.ProductID equals sod.ProductID
                                   group sod by pr.Name into groupedproducts
                                   select new
                                   {
                                       Name = groupedproducts.Key,
                                       orderDetails = groupedproducts
                                   };
                var SoldProductsInOrder = SoldProducts.OrderByDescending(o => o.orderDetails.Sum(x => x.OrderQty));
                foreach (var produ in SoldProductsInOrder)
                {
                    int totalQty = 0;
                    foreach (var q in produ.orderDetails)
                    {
                        totalQty += q.OrderQty;
                    }
                    Console.WriteLine($"{produ.Name,-40}  was sold in qty of {totalQty}");
                }

            }

        }

        // 9. Wyświetl raport jak w zadaniu 8, ale per dany rok(group by)

        private static void ShowProductsSalesByYear()
        {
            using (AW2012Context DbContext = new AW2012Context())
            {
                var SoldProducts = from pr in DbContext.Products
                                   join sod in DbContext.SalesOrderDetails
                                   on pr.ProductID equals sod.ProductID
                                   join soh in DbContext.SalesOrderHeaders
                                   on sod.SalesOrderID equals soh.SalesOrderID
                                   select new
                                   {
                                       soh.OrderDate,
                                       pr.Name,
                                       sod.OrderQty
                                   };

                var productsInYear = SoldProducts.GroupBy(x => x.OrderDate.Year).ToList();
                foreach (var year in productsInYear)
                {
                    var prods = SoldProducts.Where(x => x.OrderDate.Year.Equals(year.Key));
                    var prodsGrouppedByName = prods.GroupBy(x => x.Name);
                    var prodsOrderedByQty = prodsGrouppedByName.OrderByDescending(x => x.Sum(y => y.OrderQty));
                    Console.WriteLine($"In year {year.Key}" + $"{Environment.NewLine}" + $"{Environment.NewLine}");
                    foreach (var prod in prodsOrderedByQty)
                    {
                        int totalQty = prod.Sum(x => x.OrderQty);

                        Console.WriteLine($"{prod.Select(x => x.Name).First(),-40}  were sold in qty of {totalQty}");
                    }
                    Console.WriteLine($"{Environment.NewLine}" + $"{Environment.NewLine}");
                }
            }
            
        }

        // 10. Wyświetl raport wydanych pieniędzy przez customera, od najbardziej
        // dochodowych Customerów – interesuje nas tylko pierwszych TOP 10 najważniejszych klientów

        private static void Display10MostValuableClients()
        {
            using (AW2012Context dbContext = new AW2012Context())
            {
                var Transactions = from soh in dbContext.SalesOrderHeaders                              
                              join per in dbContext.People
                              on soh.CustomerID equals per.BusinessEntityID                              
                              select new
                              {
                                  per.BusinessEntityID,
                                  per.LastName,
                                  per.FirstName,
                                  soh.TotalDue
                              };
                var TransactsGroupped = Transactions.GroupBy(c => c.BusinessEntityID);
                var valuableClients = TransactsGroupped.OrderByDescending(c => c.Sum(t => t.TotalDue)).Take(10);
                foreach (var cl in valuableClients)
                {
                    var client = cl.First();
                    var amountSpent = cl.Sum(t => t.TotalDue);
                    Console.WriteLine($"Client {client.FirstName} {client.LastName} made orders for ${amountSpent}");
                }
            }
        }


        // 11. Ile sklepów mamy w danym mieście w bazie AdventureWorks2012?

        private static void ShowAmountOfShopsPerCity()
        {
            using(AW2012Context dbContext = new AW2012Context())
            {
                var Shops = from st in dbContext.Stores
                            join bea in dbContext.BusinessEntityAddresses
                            on st.BusinessEntityID equals bea.BusinessEntityID
                            join ad in dbContext.Addresses
                            on bea.AddressID equals ad.AddressID                           
                            select new
                            {
                                st.Name,
                                ad.City,
                                ad.AddressID
                            };
                var ShopsGrouppedByCity = Shops.GroupBy(x => x.City);
                foreach (var city in ShopsGrouppedByCity)
                {
                    
                    Console.WriteLine($"{city.Key, -25}  {city.Select(x=>x.Name).Count()} shop(s)");
                }
            }
        }


    }
}
