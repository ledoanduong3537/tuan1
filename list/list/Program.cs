using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };
           // chèn phần tử 24 vào vị trí 2
            intList.Insert(2, 24);

            //sử dụng foreach để truy xuất toàn bộ phần tử
            Console.WriteLine("\nsử dụng foreach\n");
            //intList.ForEach(el => Console.WriteLine(el));

            foreach (var el in intList)
                Console.WriteLine(el);
            // xóa phần tử thứ 3
            intList.RemoveAt(3);
            //sử dụng for để truy xuất phần tử
            Console.WriteLine("\nsử dụng for\n");

            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);

        }
    }
}
