using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plase input your sentence");
            string str = Console.ReadLine();

            WordCount sentence = new WordCount();
            
            Console.WriteLine("Number of words = {0}", sentence.GetNumberofWords(str));
            Console.ReadKey();
        }
    }
}
