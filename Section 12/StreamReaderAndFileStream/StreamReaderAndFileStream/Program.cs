namespace StreamReaderAndFileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? path = @"C:\Working-with-files\file1.txt";
            FileStream? fileStream = null;
            StreamReader? streamReader = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream   );
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);   
            }

        }
    }
}