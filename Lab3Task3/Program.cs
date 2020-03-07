using System;
using System.IO;
using System.Text;

namespace Lab3Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' };
            StringBuilder result = new StringBuilder();
            using (StreamReader File = new StreamReader(@"C:\Users\User\Desktop\C#Programming\Lab3Task3\text.txt"))
            {
                if (File == null)
                    Console.WriteLine("File missing!");
                else
                {
                    while ((line = File.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        string[] words = line.Split(separator);
                        foreach (string word in words)
                        {
                            if ((word.Length >= 2))
                            {
                                result.Append(word[0]);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Result: ");
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
