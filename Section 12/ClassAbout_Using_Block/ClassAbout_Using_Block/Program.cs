using System.IO;

namespace ClassAbout_Using_Block
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Working-with-files\file1.txt";

            try
            {   
                    using (StreamReader streamReader = File.OpenText(path))
                    {
                        while (!streamReader.EndOfStream) 
                        {
                            string line = streamReader?.ReadLine() ?? throw new IOException();
                            Console.WriteLine(line);
                        }
                    }    
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured:");
                Console.WriteLine(e.Message);
            }
        }
    }
}