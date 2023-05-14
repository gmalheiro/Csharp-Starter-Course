namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\Working-with-files\Exercise 1\products.csv";
            string sourceFolderPath = @"C:\Working-with-files\Exercise 1\";
            string targetPath = @"C:\Working-with-files\Exercise 1\out\summary.csv";
            try
            {
                using (StreamReader streamReader = File.OpenText(sourceFilePath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string product = streamReader?.ReadLine() ?? throw new IOException();
                        string[] productData = product.Split(',');
                        string productName = productData[0];
                        double productPrice = double.Parse(productData[1]);
                        int productQuantity = int.Parse(productData[2]);
                        double total = productPrice * productQuantity;
                        Directory.CreateDirectory(sourceFolderPath + @"\out");
                        using (StreamWriter streamWriter = File.AppendText(targetPath))
                        {   
                            streamWriter.WriteLine(productName + "," + total.ToString("F2"));
                        }
                    }
                }
                string productsCSV = File.ReadAllText(sourceFilePath);
                string productsSummary = File.ReadAllText(targetPath);
                Console.WriteLine(productsCSV);
                Console.WriteLine("\n"+productsSummary);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured:");
                Console.WriteLine(e.Message);
            }
        }
    }
}