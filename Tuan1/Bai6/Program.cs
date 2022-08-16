using System;
using System.Text;
namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình tính tổng các số nguyên dương từ 0-n---------");
            Console.WriteLine("Nhập số nguyên dương n");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum+=i;
                
            }
            Console.WriteLine($"Tổng: {sum}");

        }
    }
}