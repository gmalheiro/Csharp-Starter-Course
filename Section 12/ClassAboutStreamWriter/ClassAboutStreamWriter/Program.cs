namespace ClassAboutStreamWriter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Working-With-Files\file1.txt";
            string targetPath = @"C:\Working-With-Files\file2.txt";

            try
            {
                //using (StreamWriter streamWriter = File.AppendText(targetPath))
                //{
                //    string[] lines = File.ReadAllLines(sourcePath);
                //    foreach (string line in lines)
                //    {
                //        streamWriter.WriteLine(line.ToUpper());
                //    }
                //}
                StreamReader streamReader = File.OpenText(targetPath); //Opening the text using the File class
                //StreamReader streamReader = new StreamReader(new FileStream (targetPath,FileMode.Open)); Opening the text using the FileStream class
                Console.WriteLine(streamReader.ReadToEnd());
            } 
            catch (IOException e)
            {
                Console.WriteLine("An error occured:");
                Console.WriteLine(e.Message);
            }
        }
    }
}