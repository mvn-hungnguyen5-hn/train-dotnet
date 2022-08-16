using System;
using System.Text;

namespace Bai2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 số nguyên (1-9):");
            try {
              int number = Convert.ToInt32(Console.ReadLine());
              string readNumber = "";
              switch (number)
              {
                case 1:
                    readNumber = "Một";
                break;
                case 2:
                    readNumber = "Hai";
                break;
                case 3: 
                    readNumber = "Ba";
                break;
                case 4:
                    readNumber = "Bốn";
                break;
                case 5:
                    readNumber = "Năm";
                break;
                case 6:
                    readNumber = "Sáu";
                break;
                case 7:
                    readNumber = "Bảy";
                break;
                case 8:
                    readNumber = "Tám";
                break;
                case 9:
                    readNumber = "Chín";
                break;
                default: 
                    readNumber = "Một số nguyên không trong khoảng (1-9)";
                break;
              }
              Console.WriteLine($"{number} -> {readNumber}");
            } catch (FormatException e) {
                Console.WriteLine("Nhập số không đúng định dạng");
                Console.WriteLine("{0} Exception caught.", e);
            }
            
        }
    }
}

