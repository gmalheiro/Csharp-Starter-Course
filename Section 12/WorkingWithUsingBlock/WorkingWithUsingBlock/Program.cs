﻿namespace WorkingWithUsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? path = @"C:\Working-with-files\file1.txt";
            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string? line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
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