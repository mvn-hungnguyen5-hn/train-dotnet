using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình kiểm tra mã số sinh viên");
            Console.WriteLine("Nhập mã số sinh viên Bxxxxxxx:");
            string studentId = Console.ReadLine();
            string regex = "B[0-9]{7}";
            bool match = Regex.IsMatch(studentId, regex);
            if (match) {
                Console.WriteLine("Nhập mã số sinh viên hợp lệ");
            } else {
                Console.WriteLine("Nhập mã số sinh viên không hợp lệ");
            }

        }
    }
}

