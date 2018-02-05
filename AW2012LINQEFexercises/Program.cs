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
            ShowProductsSalesByYear();

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
            Console.WriteLine("finito");
        }

        // 10. Wyświetl raport wydanych pieniędzy przez customera, od najbardziej
        // dochodowych Customerów – interesuje nas tylko pierwszych TOP 10 najważniejszych klientów
    }
}
