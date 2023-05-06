using System.IO;
namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Working-with-files\file1.txt";
            string targetPath = @"C:\Working-with-files\file4.txt";
             
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                Console.WriteLine("File copied!");
                string [] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}