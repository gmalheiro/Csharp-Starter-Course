namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path:");
            string path = Console.ReadLine()!;
            SortedDictionary<string, int> candidates = new SortedDictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine()!.Split(",");
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (candidates.ContainsKey(name))
                        {
                            candidates[name] += votes;
                        }
                        else
                        {
                            candidates.Add(name, votes);
                        }
                    }

                    foreach (KeyValuePair<string, int> candidate in candidates)
                    {
                        Console.WriteLine(candidate.Key + ":" + candidate.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}