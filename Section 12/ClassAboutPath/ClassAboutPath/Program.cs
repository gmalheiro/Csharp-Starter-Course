namespace ClassAboutPath
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Working-with-files\myFolder\file1.txt";
            Console.WriteLine("GetDirectoryName :" + Path.GetDirectoryName(path));
            Console.WriteLine("DirectorySeparatorChar:" + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator:" + Path.PathSeparator);
            Console.WriteLine("GetFileName:" + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithouExtension:" + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension:" + Path.GetExtension(path));
            Console.WriteLine("GetFullPath :" + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath:" + Path.GetTempPath());
        }
    }
}