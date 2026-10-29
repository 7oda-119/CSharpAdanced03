using System.Reflection.Metadata;
using System.Xml.Linq;

namespace C_Adanced03;

internal class Program
{
    static void Main(string[] args)
    {
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

        #region Exercise 2: Leaderboard
        //SortedDictionary<int, string> sortedDictionary = new()
        //{   { 500, "Ahmed" },
        //    { 200, "Sara" },
        //    { 800, "Ali" },
        //    { 350, "Mona" }
        //};

        //foreach (var elemnt in sortedDictionary)
        //    Console.WriteLine($"{elemnt.Key} => \"{elemnt.Value}\"");

        //Console.WriteLine("First key: " + sortedDictionary.Keys.First());
        //Console.WriteLine("First value: " + sortedDictionary.Values.First());

        //Console.WriteLine("Contains score 500 ? " + sortedDictionary.ContainsKey(500));

        //if(sortedDictionary.TryGetValue(999, out string value))
        //    Console.WriteLine("The score 999: " + value);
        //else
        //    Console.WriteLine("The value of score 999 not found.");

        //sortedDictionary.Remove(200);
        //foreach (var elemnt in sortedDictionary)
        //    Console.WriteLine($"{elemnt.Key} => \"{elemnt.Value}\"");

        #endregion

        #region Exercise 3: Phone Book
        //Dictionary<string, string> contacts = new();

        //contacts["Ahmed"] = "01012345";
        //contacts["Ali"] = "01123456";
        //contacts["Mohamed"] = "01598765";
        //contacts["Ali"] = "01057345";

        //try
        //{
        //    contacts.Add("Ali", "01234567890");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex);
        //}

        //string addingContact = contacts.TryAdd("Omar", "01234567890") ? "Suceeded." : "Failed.";
        //Console.WriteLine("\nadding {Omar, 01234567890} " + addingContact);

        //string searshingFor = "Ziad";
        //if (contacts.ContainsKey(searshingFor))
        //    Console.WriteLine($"The phonenumber of {searshingFor}: {contacts[searshingFor]}");
        //else
        //    Console.WriteLine($"The phonenumber of {searshingFor}: doesn’t exist.");

        //string phoneNumber = contacts.GetValueOrDefault(searshingFor, "Not found.");
        //Console.WriteLine($"{searshingFor}'s phone: " + phoneNumber);

        //Console.WriteLine("Keys: " + string.Join(", ", contacts.Keys));
        //Console.WriteLine("Values: " + string.Join(", ", contacts.Values));

        #endregion

        #region Exercise 4: Unique Email Validator
        //HashSet<string> hashEmails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        //hashEmails.Add("ahmed@test.com");
        //hashEmails.Add("AHMED@test.com");
        //hashEmails.Add("sara@test.com");
        //hashEmails.Add("Sara@Test.Com");

        //Console.WriteLine("Count: " + hashEmails.Count);   // because HashSet stores only unique values, and the StringComparer.OrdinalIgnoreCase ignore case-sensitivity of letters
        //HashSet<int> A = [1, 2, 3, 4, 5];
        //HashSet<int> B = [4, 5, 6, 7, 8];

        //HashSet<int> union = new HashSet<int>(A);
        //union.UnionWith(B);
        //Console.WriteLine("UnionWith: " + string.Join(", ", union));

        //HashSet<int> intersect = new HashSet<int>(A);
        //intersect.IntersectWith(B);
        //Console.WriteLine("IntersectWith: " + string.Join(", ", intersect));

        //HashSet<int> except = new HashSet<int>(A);
        //except.ExceptWith(B);
        //Console.WriteLine("ExceptWith: " + string.Join(", ", except));

        //HashSet<int> subset = [ 1, 2 ];
        //Console.WriteLine("IsSubsetOf: " + subset.IsSubsetOf(A));

        #endregion

        #region Exercise 5: Print Queue Simulator

        //Queue<string> documentQueue = new();

        //documentQueue.Enqueue("Report.pdf");
        //documentQueue.Enqueue("Invoice.pdf");
        //documentQueue.Enqueue("Letter.docx");
        //documentQueue.Enqueue("Resume.pdf");
        //documentQueue.Enqueue("Photo.jpg");

        //Console.WriteLine("Print queue: " + string.Join(", ", documentQueue));

        //Console.WriteLine("Count: " + documentQueue.Count);

        //Console.WriteLine("Next Document: " + documentQueue.Peek());

        //Console.WriteLine($"Printing {documentQueue.Dequeue()}");

        //Queue<string> emptyQueue = new();
        //if(emptyQueue.TryDequeue(out string output))        // return true if there are elements and set the value of the next element in out parameter, and else if there are no any element in the queue
        //    Console.WriteLine($"Printing: {emptyQueue}");
        //else
        //    Console.WriteLine("Queue is empty. No document to print.");

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