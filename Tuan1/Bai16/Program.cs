using System.Text;

namespace Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------Chương trình tìm phần tử trong chuỗi ---------");
            Console.WriteLine("Nhập chuỗi:");
            string newString = Console.ReadLine();
            Console.WriteLine("Nhập một kí tư:");
            char keyCheck = Convert.ToChar(Console.ReadLine());
            int checkKeyInString = newString.IndexOf(keyCheck);
            if  (checkKeyInString == -1) {
                    Console.WriteLine("Không có trong chuỗi");
            } else {
                Console.WriteLine($"Có tồn tại trong chuỗi, vị trí đầu tiên xuất hiện {checkKeyInString}");
            }
        }
    }
}