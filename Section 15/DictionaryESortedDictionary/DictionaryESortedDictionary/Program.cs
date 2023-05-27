namespace DictionaryESortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> cookies =  new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "11990000000";
            cookies["phone"] = "11999999999";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email") )
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("Cookies key: [email] doesnt exist");
            }

            Console.WriteLine("Size :" + cookies.Count );

            Console.WriteLine("ALL COOKIES");
            foreach (KeyValuePair <string,string> item in cookies)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
} 