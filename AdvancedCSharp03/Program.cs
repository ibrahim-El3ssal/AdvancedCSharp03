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

            #endregion
            #region Q03

            #endregion
            #region Q04

            #endregion
            #region Q05

            #endregion
            #region Q01

            #endregion
            #region Q06

            #endregion

            Console.ReadLine();
        }
    }
}
