namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                string typeOfProduct = Console.ReadLine();
                Console.Write("Name:");
                string name = Console.ReadLine();
                double customFee = 0.0;
                DateTime manufactureDate; 
                if (typeOfProduct == "i")
                {
                    Console.Write("Customs fee:");
                    customFee = double.Parse(Console.ReadLine());
                }
                else if (typeOfProduct == "u")
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY):");
                    manufactureDate = DateTime.Parse(Console.ReadLine());
                }
            }

            Console.Write("Price Tags:");


        }
    }
}