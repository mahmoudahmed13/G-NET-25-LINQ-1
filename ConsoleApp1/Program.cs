using System.Threading;
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

            #region Question 04
            //4. Get all products where UnitPrice is between 10 and 30

            //var result = ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);
            #endregion

            #region Question 05
            //5.Get all products that are in stock(UnitsInStock > 0) and belong to the "Condiments" category.

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            #endregion

            #region Question 06
            ////6.Create a new anonymous type with three properties:
            ////● Name → the product name
            ////● Price → the unit price
            ////● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            ////● Print the result.

            //var result = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock switch
            //    {
            //        > 0 => "Avalible",
            //        _ => "Out of Stock"
            //    }
            //});

            #endregion

            #region Question 07
            //7.Print each product's name along with its position (1-based) in the list.
            //Expected format: 1. Chai, 2. Chang, etc.

            //var result = ProductList.Select((p, i) => $"{i + 1}.{p.ProductName}");

            #endregion

            #region Question 08
            //8.Sort ProductList by Category ascending,
            //then within each category, sort by UnitPrice descending.

            //var result = ProductList.OrderBy(p => p.Category)
            //                        .ThenBy(p => p.UnitPrice);       
            #endregion

            //foreach (var item in result)
            //    Console.WriteLine(item);
        }
    }
}
