namespace AdvancedCSharp03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01
            Console.WriteLine("\nQ01\n");
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            Console.WriteLine("All Grades: " + string.Join(", ", grades));
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First Grade: {grades.First()}"); 
            Console.WriteLine($"Last Grade: {grades.Last()}");

            grades.Sort(); 
            Console.WriteLine("Sorted Ascending: " + string.Join(", ", grades));

            int firstAbove90 = grades.First(g => g > 90);
            Console.WriteLine($"First grade above 90: {firstAbove90}");


            List<int> failingGrades = new List<int>();

            foreach (int g in grades)
            {
                if (g < 75)
                {
                    failingGrades.Add(g);
                }
            }
            Console.WriteLine("Failing Grades (below 75): " + string.Join(", ", failingGrades));


            grades.RemoveAll(g => g < 75);
            Console.WriteLine("Grades after removing failing ones: " + string.Join(", ", grades));

            bool has100 = false;

            foreach (int g in grades)
            {
                if (g == 100)
                {
                    has100 = true;
                    break; 
                }
            }
            Console.WriteLine($"Contains 100 : {has100}");

            
            List<string> gradeMessages = new List<string>();

            foreach (int g in grades)
            {
                gradeMessages.Add($"Grade: {g}");
            }

            Console.WriteLine("Formatted Grades:");
            foreach (string message in gradeMessages)
            {
                Console.WriteLine(message);
            }

            #endregion

            #region Q02
            Console.WriteLine("\nQ02\n");

            SortedList<int, string> leaderboard = new SortedList<int, string>();

            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");

            Console.WriteLine("--- Leaderboard (Sorted) ---");
            foreach (KeyValuePair<int, string> item in leaderboard)
            {
                Console.WriteLine($"Score: {item.Key} -> Player: {item.Value}");
            }

            int firstScore = leaderboard.Keys[0];
            string firstPlayer = leaderboard.Values[0];

            Console.WriteLine($"First Key -> Score: {firstScore}, first value (Player): {firstPlayer}");

            int targetScore = 500;
            bool exists = leaderboard.ContainsKey(targetScore);

            Console.WriteLine($"Does score {targetScore} exist? {exists}");

            int searchScore = 999;
            string playerName; 

            if (leaderboard.TryGetValue(searchScore, out playerName))
            {
                Console.WriteLine($"Player with score {searchScore}: {playerName}");
            }
            else
            {
                Console.WriteLine($"Player with score {searchScore} not found ");
            }

            int scoreToRemove = 200;
            leaderboard.Remove(scoreToRemove);

            Console.WriteLine("\n--- Updated Leaderboard (After Removing Score 200) ---");
            foreach (KeyValuePair<int, string> kvp in leaderboard)
            {
                Console.WriteLine($"Score: {kvp.Key} -> Player: {kvp.Value}");
            }
            #endregion

            #region Q03
            Console.WriteLine("\nQ03\n");

            Dictionary<string, string> phoneBook = new Dictionary<string, string>
                {
                    { "Ahmed", "01012345678" },
                    { "Sara", "01298765432" },
                    { "Ali", "01155554444" },
                    { "Mona", "01599887766" }
                };

            phoneBook["Khaled"] = "01099887766";

            try
            {
                phoneBook.Add("Ahmed", "01011112222");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error caught: {ex.Message}");
            }

            bool isAdded = phoneBook.TryAdd("Ahmed", "01000000000");
            Console.WriteLine($"Did the addition succeed? {isAdded}");

            string searchContact = "Mahmoud";
            bool exist = phoneBook.ContainsKey(searchContact);

            Console.WriteLine($"Does contact '{searchContact}' exist? {exist}");

            string targetName = "Ibrahim"; 
            string resultNumber = phoneBook.GetValueOrDefault(targetName, "Not Found");

            Console.WriteLine($"Result for '{targetName}': {resultNumber}");
    
            Console.WriteLine("\n--- Phone Book Keys & Values ---");

            Console.WriteLine("Contacts (Keys): " + string.Join(", ", phoneBook.Keys));

            Console.WriteLine("Numbers (Values): " + string.Join(", ", phoneBook.Values));

            #endregion

            #region Q04
            Console.WriteLine("\nQ04\n");

            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine($"Total unique emails : {emails.Count}");
            /// HashSet : store unique elements
            /// Case-Insensitive Comparison (StringComparer.OrdinalIgnoreCase): ignore differences between uppercase and lowercase letters when comparing strings.
            /// "ahmed@test.com" , "AHMED@test.com" and "sara@test.com" and "Sara@Test.Com" were treated as the exact same email, so only the first one was stored.

            
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSet<int> unionSet = new HashSet<int>(setA);
            unionSet.UnionWith(setB);
            Console.WriteLine("Union: " + string.Join(", ", unionSet));
            

            HashSet<int> intersectSet = new HashSet<int>(setA);
            intersectSet.IntersectWith(setB);
            Console.WriteLine("Intersect : " + string.Join(", ", intersectSet));

            HashSet<int> exceptSet = new HashSet<int>(setA);
            exceptSet.ExceptWith(setB);
            Console.WriteLine("Except: " + string.Join(", ", exceptSet));

            bool isSubset = new HashSet<int> { 1, 2 }.IsSubsetOf(setA);

            Console.WriteLine($"Is {{1, 2}} a subset of Set A? {isSubset}");
            #endregion

            #region Q05
            Console.WriteLine("\nQ05\n");
            Queue<string> printQueue = new Queue<string>();

            printQueue.Enqueue("Report.pdf");
            printQueue.Enqueue("Invoice.pdf");
            printQueue.Enqueue("Letter.docx");
            printQueue.Enqueue("Resume.pdf");
            printQueue.Enqueue("Photo.jpg");

            Console.WriteLine($"Total documents in queue: {printQueue.Count}");
            Console.WriteLine("Queue contents: " + string.Join(", ", printQueue));

            string nextDoc = printQueue.Peek();

            Console.WriteLine($"Next document (Peek): {nextDoc}");

            Console.WriteLine("\n--- Processing Print Queue ---");

            while (printQueue.Count > 0)
            {
                string doc = printQueue.Dequeue();
                Console.WriteLine($"Printing: {doc}");
            }

            Console.WriteLine($"Queue count after processing: {printQueue.Count}");

            bool success = printQueue.TryDequeue(out string? resultDoc);

            if (success)
            {
                Console.WriteLine($"Successfully dequeued: {resultDoc}");
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }

            #endregion

            #region Q06
            Console.WriteLine("\nQ06\n");
            Stack<string> browserHistory = new Stack<string>();

            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("stackoverflow.com");
            browserHistory.Push("youtube.com");
            browserHistory.Push("claude.ai");

            string currentPage = browserHistory.Peek();
            Console.WriteLine($"Current active page (Peek): {currentPage}");

            Console.WriteLine("\n--- Going Back 3 times ---");
            for (int i = 0; i < 3; i++)
            {
                string leftPage = browserHistory.Pop();
                Console.WriteLine($"Leaving page: {leftPage}");
            }

            string currentAfterBack = browserHistory.Peek();
            Console.WriteLine($"\nCurrent page after back: {currentAfterBack}");

            browserHistory.Clear();
            bool IsSuccess = browserHistory.TryPop(out string? resultPage);

            if (IsSuccess)
            {
                Console.WriteLine($"Successfully popped: {resultPage}");
            }
            else
            {
                Console.WriteLine("Browser history is empty  ");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
