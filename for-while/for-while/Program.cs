using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var i = 0;
            Console.WriteLine("vòng lặp while\n");
            while (i < 10)
            {
                Console.Write($"{i}\t");
                i++;
            }
            Console.WriteLine("\r\n vòng lặp do-while\n");
            i = 0;
            do
            {
                Console.Write($"{i}\t");
                i++;
            } while (i < 10);
            Console.WriteLine("\r\nVòng lặp for\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
