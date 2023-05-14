namespace ClassAbout_File_File_IOException
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? sourcePath = @"C:\Working-with-files\file1.txt";
            int incrementValue = 0;
            string? targetPath = @"C:\Working-with-files\file2.txt";
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    int digitPosition = targetPath.IndexOfAny("0123456789".ToCharArray());
                    string letterPart = targetPath.Substring(0, digitPosition);
                    string numberPart = targetPath.Substring(digitPosition, 1);
                    string extension = ".txt";
                    incrementValue += i;
                    int incrementedNumber = int.Parse(numberPart) + incrementValue;
                    targetPath = letterPart + incrementedNumber.ToString() + extension;
                    FileInfo fileInfo = new FileInfo(sourcePath);
                    fileInfo.CopyTo(targetPath);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}