namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> studentNumbers = new HashSet<int>();

            Console.Write("How many students for course A?");
            int courseStudents = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < courseStudents; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine()!); 
                studentNumbers.Add(studentNumber);
            }
            Console.Write("How many students for course B?");
            courseStudents = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < courseStudents; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine()!);
                studentNumbers.Add(studentNumber);
            }
            Console.Write("How many students for course c?");
            courseStudents = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < courseStudents; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine()!);
                studentNumbers.Add(studentNumber);
            }

            Console.WriteLine("Total Students:" + studentNumbers.Count);
        }
    }
}