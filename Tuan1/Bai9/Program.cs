using System.Text;
namespace Bai9
{
    internal class Program
    {
        static int fibonaci(int n){
            if (n == 0 || n == 1) {
                return 1;
            } else {
                return fibonaci(n-1) + fibonaci(n-2);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình in ra số Fibonaci F(n) ---------");
            Console.WriteLine("Nhập số nguyên dương n");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fibonaci của số {number} là {fibonaci(number)}");

        }
    }
}