using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVien
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int Age {get; set;}
        public string Address {get; set;}
        public double Gpa {get; set;}

        public SinhVien(){}
        public SinhVien(int id, string name, int age, string address, double gpa ) {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            Gpa = gpa;
        }
        public void showStudent() {
            Console.WriteLine($"Id: {this.Id}, Tên: {this.Name}, Tuổi: {this.Age}, Địa chỉ: {this.Address}, Gpa: {this.Gpa}");
        }
    }
}