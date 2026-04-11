using System.Xml.Linq;
using static LINQ.DataSources.Source;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            ////1. Get all products from the "Seafood" category. Print each product's name and price.

            //var result = ProductList.Where(p => p.Category == "Seafood")
            //                        //.Select(p => $"Name: {p.ProductName}, Price: {p.UnitPrice}");
            //                        .Select(p => new
            //                        {
            //                            Name = p.ProductName,
            //                            Price = p.UnitPrice
            //                        });
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Question 02
            //2.Get a list of only the product names from ProductList.Print each name. 

            //var result = ProductList.Select(p => p.ProductName).ToList();

            #endregion

            #region Question 03
            //3. Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //                        .Select(p => $"{p.ProductName} - {p.UnitPrice}");
            #endregion
            //foreach (var item in result)
            //    Console.WriteLine(item);
        }
    }
}
