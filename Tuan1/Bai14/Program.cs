using System.Text;
using System.Linq;
namespace Bai14
{
    internal class Program
    {
        public static void swapTwoElement(ref int[] array, int x, int y){
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;

        }

        public static void showArray(int [] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"{array[i]} ");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình nhập và thay đổi thứ tự các phần tử của mảng ---------");
            Console.WriteLine("Nhập số phần tử của mảng n");
            int number = Convert.ToInt32(Console.ReadLine());
            int [] arrayNumber = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i}:");
                arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            //duyệt mảng và swap phần tử:
            for (int i = 0; i <= number/2; i++) {
                swapTwoElement(ref arrayNumber, i, number-i-1);
            }
            showArray(arrayNumber);
        }
    }
}