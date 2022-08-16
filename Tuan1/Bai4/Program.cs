using System;
using System.Text;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình kiểm tra 3 cạnh của tam giác vuông");
            try {
                Console.WriteLine("Nhập lần lượt 3 cạnh của tam giác:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                if (a <= 0 || b <= 0 || c <= 0) {
                    Console.WriteLine("Phải nhập số thực dương");
                } else {
                    if ( (a + b) > c && (a - b) < c && (b + c) > a && (b - c) < a && (a + c) > b && (a - c) < b)
                    {
                        Console.WriteLine("Đây là 3 cạnh của tam giác");
                        if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a)) {
                            Console.WriteLine("Đây là tam giác vuông");
                        } else {
                             Console.WriteLine("Đây không phải là tam giác vuông");
                        }
                    } else {
                        Console.WriteLine("Đây không phải 3 cạnh của tam giác");
                    }
                }     
            } catch (FormatException e) {
                Console.WriteLine("Phải nhập số thực");
                Console.WriteLine("{0} Exception caught.", e);
            }
            
        }
    }
}

