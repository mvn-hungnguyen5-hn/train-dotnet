// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace Bai1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 số:");
            try {
              int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0) {
                Console.WriteLine("Đây là số nguyên dương");
            } else {
                Console.WriteLine("Đây là số nguyên âm");
            }  
            } catch (FormatException e) {
                Console.WriteLine("Nhập số không đúng định dạng");
                Console.WriteLine("{0} Exception caught.", e);
            }
            
        }
    }
}
