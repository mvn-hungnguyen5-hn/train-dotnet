using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình kiểm tra định dạng chuỗi nhập vào");
            Console.WriteLine("Nhập chuối số:");
            string newString = Console.ReadLine();
            string regex = "^[A-Z]\\S{1,18}[0-9]$";
            //string regex = "^\\S{,5}$";
            bool match = Regex.IsMatch(newString, regex);
            if (match) {
                Console.WriteLine("Nhập chuỗi số hợp lệ");
            } else {
                Console.WriteLine("Nhập mã chuỗi số không hợp lệ");
            }

        }
    }
}

