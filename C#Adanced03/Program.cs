namespace C_Adanced03;

internal class Program
{
    static void Main(string[] args)
    {
        #region Smart Product Search
        //ProductCatalog productCatalog = new ProductCatalog();
        //List<Product> products = productCatalog.GetProducts();

        //ProductFilterDelegate productFilter = ProductSearch.IsElectronic;
        //List<Product> electronicProducts = ProductSearch.SearchProducts(products, productFilter);
        //Console.WriteLine("--- Electronics ---");
        //PrintProducts(electronicProducts);
        //Console.WriteLine("\n========================================\n");

        //ProductFilterDelegate cheapFilter = ProductSearch.IsCheaper;
        //List<Product> cheapProducts = ProductSearch.SearchProducts(products, cheapFilter);
        //Console.WriteLine("--- Under $50 ---");
        //PrintProducts(cheapProducts);
        //Console.WriteLine("\n========================================\n");

        //ProductFilterDelegate inStockFilter = ProductSearch.IsInStock;
        //List<Product> inStock = ProductSearch.SearchProducts(products, inStockFilter);
        //Console.WriteLine("--- In Stock ---");
        //PrintProducts(inStock);
        //Console.WriteLine("\n========================================\n");

        //ProductFilterDelegate clothingUnder100Filter = ProductSearch.IsCheapClothing;
        //List<Product> clothingUnder100 = ProductSearch.SearchProducts(products, clothingUnder100Filter);
        //Console.WriteLine("--- Clothing Under $100 ---");
        //PrintProducts(clothingUnder100); 
        #endregion

        #region Custom Report Generator
        //ProductCatalog productCatalog = new ProductCatalog();
        //List<Product> products = productCatalog.GetProducts();

        //Console.WriteLine("--- Short Report ---");
        //Action<Product> shortReport = ReportGenerator.PrintShortReport;
        //ReportGenerator.GenerateReport(products, shortReport);

        //Console.WriteLine("\n========================================\n");

        //Console.WriteLine("--- Long Report ---");
        //Action<Product> longReport = ReportGenerator.PrintLongReport;
        //ReportGenerator.GenerateReport(products, longReport);
        #endregion

        #region Func
        //ProductCatalog productCatalog = new ProductCatalog();
        //List<Product> products = productCatalog.GetProducts();
        //List<string> transformList = ReportGenerator.TransformProducts(products, p => $"{p.Name} (${p.Price})");
        //foreach (string product in transformList)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion

        #region Predicate
        //ProductCatalog productCatalog = new ProductCatalog();
        //List<Product> products = productCatalog.GetProducts();
        //List<Product> filteredList = ReportGenerator.FilterProducts(products, p => p.Stock < 20);
        //foreach (Product product in filteredList)
        //{
        //    Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
        //}
        #endregion

        #region Exercise 1: Student Grade Manager
        //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
        //Console.WriteLine(string.Join(", ", grades));             // Print grades
        //Console.WriteLine(grades.Count);                          // Print count of elements
        //Console.WriteLine(grades[0]);                             // Print the first grade
        //Console.WriteLine(grades[^1]);                            // Print the lase grade

        //grades.Sort();                                            // Sort the grades
        //Console.WriteLine(string.Join(", ", grades));             // Print grades after sorting

        //List<int> gradesAbove90 = grades.FindAll(g => g > 90);    // Find the grades greater than 90
        //Console.WriteLine(string.Join(", ", gradesAbove90));      // Print the grades greater than 90

        //List<int> gradesUnder75 = grades.FindAll(g => g < 75);    // Find the grades less than 75
        //Console.WriteLine(string.Join(", ", gradesUnder75));      // Print the grades less than 75

        //grades.RemoveAll(g => g < 75);                            // Remove the failing grade
        //Console.WriteLine(string.Join(", ", grades));             // Print grades after removing the failing

        //Console.WriteLine(grades.Contains(100));                  // Check if any grade equals 100

        //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();  // grades.Select => return IEnumerable so we use .ToList to convert to list
        //Console.WriteLine(string.Join(", ", gradeStrings));                      // Print the list with formate Grade: g
        #endregion

        #region Exercise 6: Browser History (Undo)
        ////"google.com", "github.com", "stackoverflow.com", "youtube.com", "claude.ai"
        //Stack<string> browserHistory = new ();                       // LIFO
        //browserHistory.Push("google.com");                           
        //browserHistory.Push("github.com");                           
        //browserHistory.Push("stackoverflow.com");                    
        //browserHistory.Push("youtube.com");                          
        //browserHistory.Push("claude.ai");                            // The top element
        //Console.WriteLine(string.Join(", ", browserHistory));        
                                                                       
        //Console.WriteLine(browserHistory.Peek());                    // Return the last element => claude.ai
                                                                       
        //Console.WriteLine(browserHistory.Pop());                     // Pop the last element => claude.ai
        //Console.WriteLine(browserHistory.Pop());                     // Pop the last element => youtube.com
        //Console.WriteLine(browserHistory.Pop());                     // Pop the last element => stackoverflow.com
        //Console.WriteLine(browserHistory.Peek());                    // Return the last element => github.com
                                                                       
        //Stack<string> emptyHistory = new();                          // Create empty stack
        //Console.WriteLine(emptyHistory.TryPop(out string page));     // Pop on an empty stack trow an exception. TryPop() does not throw an exception. It returns false and sets the output variable to its default value


        #endregion
    }
    public static void PrintProducts(List<Product> products)
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Price:C} (Stock: {product.Stock})");
        }
    }
}