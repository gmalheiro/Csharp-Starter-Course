using MultipleInheritance.Entities;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { SerialNumber = "2002" };
            printer.ProcessDoc("My letter");
            printer.Print("My letter");

            Scanner scanner = new Scanner() { SerialNumber = "2003" };
            scanner.ProcessDoc("My email");
            Console.WriteLine(scanner.Scan());

            ComboDevice comboDevice = new ComboDevice() { SerialNumber = "2004" };
            comboDevice.ProcessDoc("My dissertation");
            comboDevice.Print("My dissertation");
            Console.WriteLine(comboDevice.Scan());
            
        }
    }
}