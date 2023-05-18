using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mang trong C#");
            Console.WriteLine("-----------------------");
            int[] n = new int[10]; 
       
         
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            // sử dụng for
            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine("Phan tu [{0}] = {1}", j, n[j]);
            //}

            // sử dụng foreach duyệt
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Phan tu [{0}] = {1}", i, j);
                i++;
            }
        }
    }
}
