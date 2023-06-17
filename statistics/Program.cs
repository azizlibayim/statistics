namespace ConsoleApp22
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter student count: ");
            int s = int.Parse(Console.ReadLine());

            string[] Students = new string[s];
            int[] Grades = new int[s];

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("Enter the student's name: ");
                Students[i] = Console.ReadLine();
            }

            for (int j = 0; j < Grades.Length; j++)
            {
                Console.WriteLine("Enter student's grade: ");
                Grades[j] = int.Parse(Console.ReadLine());
            }

            StatisticsHelper statistics = new StatisticsHelper(Grades);

            Console.WriteLine("Student List:");
            for (int k = 0; k < s; k++)
            {
                Console.WriteLine($"Name: {Students[k]}, Grade: {Grades[k]}");
            }

            Console.WriteLine($"Average Grade: {statistics.GetAverageGrade()}");
            Console.WriteLine($"Lowest Grade: {statistics.GetLowestGrade()}");
            Console.WriteLine($"Highest Grade: {statistics.GetHighestGrade()}");
        }

    
}