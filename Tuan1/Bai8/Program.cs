using System.Text;
namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình in ra số nguyên tố trong khoảng (0-n)---------");
            Console.WriteLine("Nhập số nguyên dương n");
            Console.WriteLine("Số nguyên tố trong khoảng 0-n");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                int countDiv = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0) {
                        countDiv++;
                    }

                }
                if (countDiv == 0 && i >= 2) {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}