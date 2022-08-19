using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            Console.WriteLine("Chương trình quản lí sinh viên:");
            // sinhvien.showStudent();
            while (true) {
                Console.WriteLine("/********Chương trình quản lí sinh viên*********/");
                Console.WriteLine("1. Add student.");
                Console.WriteLine("2. Edit student by id.");
                Console.WriteLine("3. Delete student by id.");
                Console.WriteLine("4. Sort student by gpa.");
                Console.WriteLine("5. Sort student by name.");
                Console.WriteLine("6. Show student.");
                Console.WriteLine("0. Exit. ");
                Console.WriteLine("/****************************************/");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Add student.");
                        quanLySinhVien.addSinhVien();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        Console.WriteLine(quanLySinhVien.getCountListSv());
                        break;
                    case 2:
                        Console.WriteLine("\n2. Edit student by id.");
                        Console.WriteLine("Nhập Id của sinh viên cần tìm kiếm:");
                        int findId = Convert.ToInt32(Console.ReadLine());
                        quanLySinhVien.editStudentById(findId);
                        break;
                    case 3:
                        Console.WriteLine("\n3.Delete student by id.");
                        Console.WriteLine("Nhập Id của sinh viên cần xoá:");
                        findId = Convert.ToInt32(Console.ReadLine());
                        bool deleteSv = quanLySinhVien.deleteStudentById(findId);
                        if (deleteSv) {
                            Console.WriteLine("Xoá sinh viên thành công");
                        } else {
                            Console.WriteLine("Xoá sinh viên không thành công");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nSort student by gpa.");
                        quanLySinhVien.sortByGpaAsc();
                        break;
                    case 5:
                        Console.WriteLine("\nSort student by name.");
                        quanLySinhVien.sortByNameAsc();
                        break;
                    case 6:
                        Console.WriteLine("\n6. Show student.");
                        quanLySinhVien.showStudents();
                        break;
                }

            }
        }
    }
}