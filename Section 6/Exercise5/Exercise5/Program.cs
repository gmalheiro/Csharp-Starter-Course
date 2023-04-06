namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list2 = new List<string>() { "Maria","Alex","Bob" } ;

            //foreach (string itemsList in list2)
            //{
            //    Console.WriteLine(itemsList);
            //}
            
            List<string> nameslist = new List<string>();

            nameslist.Add("Maria");
            nameslist.Add("Anna");
            nameslist.Add("Bob");
            nameslist.Add("Alex");
            nameslist.Add("Marco");
            foreach (string name in nameslist)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine(nameslist.Count);
            Console.WriteLine("First element With A");
            string firstElementHeFindsWhichStartsWithTheLetterA = nameslist.Find(x => x[0] == 'A');
            Console.WriteLine(firstElementHeFindsWhichStartsWithTheLetterA);
            Console.WriteLine();
            Console.WriteLine("Last element with A");
            string lastElementHeFindsWhichStartsWithLetterA = nameslist.FindLast(x => x[0] == 'A');
            Console.WriteLine(lastElementHeFindsWhichStartsWithLetterA);
            Console.WriteLine();
            int positionOfFirstElementWithA = nameslist.FindIndex(x => x[0]  == 'A');
            Console.WriteLine(positionOfFirstElementWithA);
            Console.WriteLine();
            int positionOfLastElementWithA = nameslist.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(positionOfLastElementWithA);
            Console.WriteLine();
            List<string> listNamesWithFiveCharacters = nameslist.FindAll(nameWithFiveCharacters => nameWithFiveCharacters.Length == 5);
            Console.WriteLine();
            foreach (string nameWithFive in listNamesWithFiveCharacters)
            {
                Console.WriteLine(nameWithFive);
            }
            Console.WriteLine();
            nameslist.Remove("Alex");
            foreach (string name in nameslist)
            {
                Console.WriteLine(name);
            }
            nameslist.Add("Alex");
            Console.WriteLine();
            nameslist.RemoveAll(x => x[0] ==  'M');
            foreach (string namesWithoutM in nameslist)
            {
                Console.WriteLine(namesWithoutM);
            }

            Console.WriteLine();

            nameslist.RemoveAt(0);
            foreach (string names in nameslist)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine();

            nameslist.Add("Marcos");
            nameslist.Add("Maria");


            Console.WriteLine();

            nameslist.RemoveRange(2,2);
            foreach (string name in nameslist)
            {
                Console.WriteLine(name);
            }


        }
    }
}