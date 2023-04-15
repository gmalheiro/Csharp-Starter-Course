using System.Globalization;

namespace DateTimeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //Um objeto datetime internamente armazenda o número de ticks (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano  1 da era comum(1/1/0001 00:00:00)
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            //A quantidade de ticks que passaram desde a meia noite do dia 1 de janeiro do ano 1 da era comum até a era atual
            Console.WriteLine(d1.Ticks  );

            // Instanciei um objeto do tipo DateTime passando como argumento o ano, mês e dia
            DateTime d2 = new DateTime(2023,04,13 );
            Console.WriteLine(d2);

            //Instanciei um objeto do tipo DateTime passando como argumento o ano , mês, dia, hora, minuto e segundo
            DateTime d3 = new DateTime(2018,04,3,10,5,11);
            Console.WriteLine(d3);

            //Instanciei um objeto do tipo DateTime passando como argumento o ano, mês, dia, hora, minuto, segundo e milisegundo
            DateTime d4 = new DateTime(2018, 04, 3, 10, 5, 11,500);
            Console.WriteLine(d4);

            // Instanciei um objeto do tipo DateTime passando como argumento o momento de agora
            DateTime d5 = DateTime.Now;
            Console.WriteLine(d5);


            // Instanciei um objeto do tipo DateTime passando como argumento o momento o dia de hoje que vai começar às 00:00:00
            DateTime d6 = DateTime.Today;
            Console.WriteLine(d6);


            //HORÁRIO DE AGORA SÓ QUE LÁ NO GMT
            DateTime d7 = DateTime.UtcNow;
            Console.WriteLine(d7);


            //Usando o parse para converter qualquer data em qualquer formato em objeto do tipo DateTime
            DateTime d8 = DateTime.Parse("2020-03-20");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("2020-03-20 13:05:58");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("04-13-2023", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.Parse("04-13-2023 13:05:58");
            Console.WriteLine(d11);


            //Usando o parseExact para definir o formato customizado da data
            DateTime d12 = DateTime.ParseExact("2020-03-20", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);

            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture)
            Console.WriteLine(d13);

        }
    }
}