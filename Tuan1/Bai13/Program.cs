using System.Text;
using System.Linq;
namespace Bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình nhập và in ra phần tử nhỏ nhất của mảng ---------");
            Console.WriteLine("Nhập số phần tử của mảng n");
            int number = Convert.ToInt32(Console.ReadLine());
            int [] arrayNumber = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i}:");
                arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = arrayNumber.Min();
            Console.WriteLine($"Phần tử nhỏ nhất của mảng: {min}");
        }
    }
}