namespace ClassAbout_FileStream_StreamReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Working-with-files\file1.txt";
            //FileStream? fileStream = null;
            StreamReader? streamReader = null;
            try
            {
                //fileStream = new FileStream(path, FileMode.Open); Kinda of saves it, it opens the file and get all the content inside of it
                //streamReader = new StreamReader(fileStream = new FileStream(path, FileMode.Open)); // Has the file with it 
                streamReader = File.OpenText(path); //It uses the file class is static, when using the open text it implicitly uses the filestream
                //while (!streamReader.EndOfStream)
                //{
                //    string? line = streamReader.ReadLine(); // Read just a line in the text document
                //    Console.WriteLine(line);
                //}
                string? line = streamReader.ReadToEnd(); // Reads all to the end of the stream
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occcured");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}