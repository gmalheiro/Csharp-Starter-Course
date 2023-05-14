namespace ClassAbout_Directory_DirectoryInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Working-with-files\myFolder";
            
            try
            {
                //IEnumerable <string> folders = Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);
                var folders = Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach ( string folder in folders)
                {
                    string folderName = folder.Substring(folder.LastIndexOf(@"\") + 1);
                    Console.WriteLine(folderName);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("\nFILES:");
                foreach (string file in files)
                {
                    string fileName = file.Substring(file.LastIndexOf(@"\") + 1);
                    Console.WriteLine(fileName);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: ");
                Console.WriteLine(e.Message);    
            }
        }
    }
}