using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsFromSentence2; 
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string input = Console.ReadLine();
        string[] words = SplitText(input);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        Console.ReadKey();
    }

    /// <summary>
    /// Этот метод разбивает введенное предложение на отдельные слова и сохраняет их в массив words
    /// </summary>
    static string[] SplitText(string text)
    {
        string[] words = text.Split(' ');
        return words;
    }
}
