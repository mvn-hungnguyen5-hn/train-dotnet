using System;
using System.Text;
namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình tính các phép nhân---------");
            Console.WriteLine("Nhập số nguyên dương n");
            int number = Convert.ToInt32(Console.ReadLine());
            int tich = 0;
            for (int i = 1; i <= 20; i++)
            {
                tich = number*i;
                Console.WriteLine($"Tích {number}x{i}: {tich}");
                
            }
        }
    }
}