namespace TratamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            //Nesse caso se a divisão for por zero vai aparecer essa minha mensagem de erro
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Division by 0 not allowed");
            }
            //Nesse caso se o usuário digitar um valor que não seja um número do formato especificado vai aparecer a mensagem Format error e a mensagem dizendo o que você fez de errado
            catch (FormatException e)
            {
                Console.WriteLine("Format error " + e.Message);
            }

        }
    }
}