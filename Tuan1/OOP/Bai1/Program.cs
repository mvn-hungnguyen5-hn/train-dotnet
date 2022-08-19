using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình cộng trừ nhân chia hai phân số:");
            Phanso phanso1 = new Phanso(1,2);
            Phanso phanso2 = new Phanso(2,3);
            Phanso phanso3 = phanso1.congphanso(phanso1, phanso2);
            phanso3.inPhanSo();
        }
    }
}