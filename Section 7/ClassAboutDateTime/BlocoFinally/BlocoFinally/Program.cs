namespace BlocoFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException )
            {
                Console.WriteLine($"You don't have this file or location in your system!");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }

            }
    }
}