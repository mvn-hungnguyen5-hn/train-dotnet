using System.Text;
using System.Linq;
namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình nhập và in phần tử lớn nhất của mảng ---------");
            Console.WriteLine("Nhập số phần tử của mảng n");
            int number = Convert.ToInt32(Console.ReadLine());
            int [] arrayNumber = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i}:");
                arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arrayNumber.Max();
            Console.WriteLine($"Phần tử lớn nhất của mảng: {max}");
        }
    }
}