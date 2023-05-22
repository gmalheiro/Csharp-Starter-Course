using UsingInterfaceIComparable.Entities;

namespace UsingInterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Working-with-files\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr?.EndOfStream ?? false)
                    {
                        list.Add(new Employee(sr!.ReadLine()!));
                    }
                    list.Sort();
                    foreach (var emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }

        }
    }
}