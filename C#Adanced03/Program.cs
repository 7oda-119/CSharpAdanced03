namespace C_Adanced03;

internal class Program
{
    static void Main(string[] args)
    {

        #region Advanced 02
        #region Task 03 : Custom Report Generator
        #region 3.2. Transform Products 
        //ProductCatalog productCatalog = new ProductCatalog();
        //List<Product> products = productCatalog.GetProducts();
        //List<string> transformList = ReportGenerator.TransformProducts(products, p => $"{p.Name} (${p.Price})");
        //foreach (string product in transformList)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion

        #region 3.3. Filter Products 
        //ProductCatalog productCatalog = new ProductCatalog();
        //List<Product> products = productCatalog.GetProducts();
        //List<Product> filteredList = ReportGenerator.FilterProducts(products, p => p.Stock < 20);
        //foreach (Product product in filteredList)
        //{
        //    Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
        //}
        #endregion
        #endregion
        #endregion

        #region Advanced 03

        #region Exercise 1: Student Grade Manager
        //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
        //Console.WriteLine("Grades = " + string.Join(", ", grades));              // Print grades

        //Console.WriteLine("Count = " + grades.Count);                            // Print count of elements
        //Console.WriteLine("The first grade = " + grades[0]);                     // Print the first grade
        //Console.WriteLine("The last grade = " + grades[^1]);                     // Print the lase grade

        //PrintSpace();

        //grades.Sort();                                                            // Sort the grades
        //Console.WriteLine("After sorting : " + string.Join(", ", grades));        // Print grades after sorting

        //PrintSpace();

        //List<int> gradesAbove90 = grades.FindAll(g => g > 90);                               // Find the grades greater than 90
        //Console.WriteLine("Grades greater than 90" + string.Join(", ", gradesAbove90));      // Print the grades greater than 90

        //PrintSpace();

        //List<int> gradesUnder75 = grades.FindAll(g => g < 75);                            // Find the grades less than 75
        //Console.WriteLine("Grades less than 75" + string.Join(", ", gradesUnder75));      // Print the grades less than 75

        //PrintSpace();

        //grades.RemoveAll(g => g < 75);                                                          // Remove the failing grade
        //Console.WriteLine("Grades after removing the failing" + string.Join(", ", grades));     // Print grades after removing the failing

        //PrintSpace();

        //Console.WriteLine("Does any degree equal 100? " + grades.Contains(100));      // Check if any grade equals 100

        //PrintSpace();

        //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();     // grades.Select => return IEnumerable so we use .ToList to convert to list
        //Console.WriteLine(string.Join(", ", gradeStrings));                         // Print the list with formate Grade: g
        #endregion

        #region Exercise 6: Browser History (Undo)
        //Stack<string> browserHistory = new();    // LIFO

        //browserHistory.Push("google.com");
        //browserHistory.Push("github.com");
        //browserHistory.Push("stackoverflow.com");
        //browserHistory.Push("youtube.com");
        //browserHistory.Push("claude.ai");

        //Console.WriteLine("Browser history: " + string.Join(", ", browserHistory));

        //PrintSpace();

        //Console.WriteLine("The last element: " + browserHistory.Peek());       // Return the last element => claude.ai

        //PrintSpace();

        //Console.WriteLine("The first pop: " + browserHistory.Pop());          // Pop the last element => claude.ai
        //Console.WriteLine("The second pop: " + browserHistory.Pop());         // Pop the last element => youtube.com
        //Console.WriteLine("The third pop: " + browserHistory.Pop());          // Pop the last element => stackoverflow.com

        //PrintSpace();

        //Console.WriteLine("Access the last element after pops: " + browserHistory.Peek());   // Return the last element => github.com

        //PrintSpace();

        //Stack<string> emptyHistory = new();
        //Console.WriteLine("TryPop the last element in empty stack: " + emptyHistory.TryPop(out string page));     // Pop on an empty stack trow an exception. TryPop() does not throw an exception. It returns false and sets the output variable to its default value
        #endregion 

        #endregion
    }
    public static void PrintSpace()
    {
        Console.WriteLine("=======================================");
    }
}