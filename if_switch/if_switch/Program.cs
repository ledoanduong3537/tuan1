using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // câu lệnh if - else

            //Console.WriteLine("Nhập vào nhiệt độ: ");
            //var input = Console.ReadLine();
            //var nhietdo = int.Parse(input);
            //if(nhietdo < 5)
            //{
            //    Console.WriteLine("lạnh quá");
            //}    
            //else if(nhietdo > 5 && nhietdo < 20) 
            //{
            //    Console.WriteLine("lạnh");
            //}
            //else if (nhietdo > 20 && nhietdo < 30)
            //{
            //    Console.WriteLine("dễ chịu");
            //}
            //else
            //{
            //    Console.WriteLine("nóng");
            //}    

            // câu lệnh switch
            Console.WriteLine("Nhập số bất kì từ 1 đến 8: ");
            var input = Console.ReadLine();
            switch (input)
            {
                case "2":
                    Console.WriteLine("thứ hai");
                    break;
                case "3":
                    Console.WriteLine("thứ ba");
                    break;
                case "4":
                    Console.WriteLine("thứ tư");
                    break;
                case "5":
                    Console.WriteLine("thứ năm");
                    break;
                case "6":
                    Console.WriteLine("thứ sáu");
                    break;
                case "7":
                    Console.WriteLine("thứ bảy");
                    break;
                case "1":
                case "8":
                    Console.WriteLine("chủ nhật");
                    break;
                default:
                    Console.WriteLine(" bạn nhập sai");
                    break;
            }


        }
    }
}
