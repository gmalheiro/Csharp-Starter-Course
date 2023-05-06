namespace StreamReaderAndFileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? path = @"C:\Working-with-files\file1.txt";
            
            StreamReader? streamReader = null;  
            try
            {
                streamReader = File.OpenText(path);
                while (!streamReader.EndOfStream)
                {

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured at:" + e.Message);   
            }
            finally 
            { 
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}