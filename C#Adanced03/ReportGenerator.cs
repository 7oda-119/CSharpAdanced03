namespace C_Adanced03;

internal class ReportGenerator
{
    public static void PrintShortReport(Product product)
        => Console.WriteLine($"{product.Name} - {product.Price:C}");
    public static void PrintLongReport(Product product)
        => Console.WriteLine($"[{product.Category}] {product.Name} | Price: {product.Price:C} | Stock: {product.Stock}");

    #region Action
    public static void GenerateReport(List<Product> products, Action<Product> reportAction)
    {
        if (products is null || products.Count == 0)
            return;

        foreach (Product product in products)
            reportAction.Invoke(product);
    }
    #endregion

    #region Func
    public static List<string> TransformProducts(List<Product> products, Func<Product, string> transformFunc)
    {
        List<string> result = [];
        if (products is not null && products.Count > 0)
        {
            foreach (Product product in products)
                result.Add(transformFunc.Invoke(product));
            return result;
        }
        return default!;

    }

    public static List<Product> FilterProducts(List<Product> products, Predicate<Product> filterPredicate)
    {
        List<Product> result = [];
        if (products is not null && products.Count > 0)
        {
            foreach (Product product in products)
            {
                if (filterPredicate.Invoke(product))
                    result.Add(product);
            }
            return result;
        }
        return default!;
    }

    #endregion

}
