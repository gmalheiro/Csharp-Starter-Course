namespace ClassAboutStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string original = "abcde FGHIJ* ABC abc DEFG";

            string originalToUpperCase = original.ToUpper();

            string originalToLowerCase = original.ToLower();

            string originalTrimmed = original.Trim();

            int originalIndexOfSmth = original.IndexOf("G");

            int originalLastIndexOfSmth = original.LastIndexOf("G");

            string originalSubstringAfterSmth = original.Substring(7);

            string substringAfterFirstG = original.Substring(7,5);

            string originalReplacingGg = original.Replace('G','g');

            string originalReplacingGString = original.Replace("GHI","ghi");

            bool originalStringIsNullOrEmpty = string.IsNullOrEmpty(original);
            bool originalStringIsNullOrWhiteSpace = String.IsNullOrWhiteSpace(original);

            Console.WriteLine(original);
            Console.WriteLine(originalToUpperCase);
            Console.WriteLine(originalToLowerCase);
            Console.WriteLine(originalTrimmed);         
            Console.WriteLine($"The index of G is:{originalIndexOfSmth}");
            Console.WriteLine($"The last index of G is:{originalLastIndexOfSmth}");
            Console.WriteLine($"The string after the letter G is:{ originalSubstringAfterSmth}");
            Console.WriteLine($"The string after the letter G and with only after 5 chars:{ substringAfterFirstG}");
            Console.WriteLine(originalReplacingGg);
            Console.WriteLine(originalReplacingGString);
            Console.WriteLine(originalStringIsNullOrEmpty);
            Console.WriteLine(originalStringIsNullOrWhiteSpace);


        }
    }
}