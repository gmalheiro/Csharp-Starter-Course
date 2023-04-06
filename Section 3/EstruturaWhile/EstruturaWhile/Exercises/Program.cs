namespace EstruturaWhile.Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Exercises" +
                          $"\n (1) Wrong Password" +
                          $"\n (2) Cartesian Coordinates" +
                          $"\n (3) Favorite Fuel" +
                          $"\nWhich exercise you want to see in action:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    WrongPassword.EnterPassword();
                    break;
                case 2:
                    Console.Clear();
                    Cartesian.CartesianCoordinates();
                    break;
                case 3:
                    Console.Clear();
                    FavoriteFuel.Fuel();
                    break;
                default:
                    Console.WriteLine("Thank you for the interest!");
                    break;
            }
        }
    }
}