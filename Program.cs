namespace ASSimentLinQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //        var result = Source.ProductList
            //.Where(p => p.Category == "Seafood");

            //        foreach (var product in result)
            //        {
            //            Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //        }
            #endregion
            #region Q2
            //var result = Source.ProductList
            //    .Select(p => p.ProductName);
            //foreach (var Product in result) {
            //    Console.WriteLine(Product);
            //}

            #endregion
            #region Q3
            //var result = Source.ProductList
            //    .OrderBy(p=>p.UnitPrice) .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}
            #endregion
            #region Q4

            //var result = Source.ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region Q5

            //var result = Source.ProductList
            //    .Where(p => p.UnitsInStock > 0 &&
            //                p.Category == "Condiments")
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitsInStock}");
            //}

            #endregion
            #region Q6

            //var result = Source.ProductList
            //    .Select(p =>
            //    {
            //        string status;

            //        if (p.UnitsInStock > 0)
            //        {
            //            status = "Available";
            //        }
            //        else
            //        {
            //            status = "Out of Stock";
            //        }

            //        return new
            //        {
            //            Name = p.ProductName,
            //            Price = p.UnitPrice,
            //            StockStatus = status
            //        };
            //    })
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine(
            //        $"{product.Name} - {product.Price} - {product.StockStatus}");
            //}

            #endregion
            #region Q7

            //var result = Source.ProductList
            //    .Select((p, index) => new
            //    {
            //        Position = index + 1,
            //        Name = p.ProductName
            //    })
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.Name}");
            //}

            #endregion
            #region Q8

            //var result = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.Category} - {product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region Q9

            //var result = Source.ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - Stock: {product.UnitsInStock}");
            //}

            #endregion
            #region Q10
            //var result =
            //    from customer in Source.CustomerList
            //    from order in customer.Orders
            //    where order.OrderDate >= new DateTime(1997, 1, 1)
            //    select new
            //    {
            //        customer.CustomerID,
            //        order.OrderDate
            //    };

            //foreach (var item in resullt)
            //{
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");
            //}

            #endregion
            #region Q11
            //        var result = Source.ProductList
            //.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    ProductName = p.ProductName
            //})
            //.ToList();

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"{item.Position}. {item.ProductName}");
            //        }

            #endregion

            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            #region Q12

            var result = Arr
                .OrderBy(word => word.Length)
                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
                .ToList();

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            #endregion
            #region Q13

            var result1 = Arr
                .Where(word => word.Length > 1 && word[1] == 'i')
                .Reverse()
                .ToList();

            foreach (var word in result1)
            {
                Console.WriteLine(word);
            }

            #endregion



        }
    }
}
