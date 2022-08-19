using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class QuanLySinhVien
    {
        private List<SinhVien> listSinhVien = null;
        public QuanLySinhVien() {
            SinhVien sinhvien1 = new SinhVien(1, "Tuan", 15, "HaNoi", 3.5);
            SinhVien sinhvien2 = new SinhVien(2, "Banh", 17, "Ha Dong", 3.1);
            SinhVien sinhvien3 = new SinhVien(3, "Yen", 19, "Ha Dong", 2.6);
            listSinhVien = new List<SinhVien>();
            listSinhVien.Add(sinhvien1);
            listSinhVien.Add(sinhvien2);
            listSinhVien.Add(sinhvien3);
        }
        public int getCountListSv(){
            return listSinhVien.Count;
        }
        public void addSinhVien() {
            SinhVien newSv = new SinhVien();
            Console.WriteLine("Nhập Id sinh viên:");
            newSv.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tên sinh viên:");
            newSv.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhập tuổi sinh viên:");
            newSv.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập địa chỉ sinh viên:");
            newSv.Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhập điểm Gpa của sinh viên:");
            newSv.Gpa = Convert.ToDouble(Console.ReadLine());
            listSinhVien.Add(newSv);
        }
        public SinhVien findSudentById(int id) {
            SinhVien sinhvien = null;
            foreach (SinhVien sv  in listSinhVien)
            {
                if (sv.Id == id) {
                    sinhvien = sv;
                    break;
                }
            }
            return sinhvien;
        }
        public void editStudentById(int id) {

            SinhVien sv = findSudentById(id);
            if (sv is not null) {
                Console.WriteLine("Thông tin sinh viên hiện tại");
                sv.showStudent();
                Console.WriteLine("Nhập Id sinh viên:");
                sv.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập tên sinh viên:");
                sv.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhập tuổi sinh viên:");
                sv.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập địa chỉ sinh viên:");
                sv.Address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhập điểm Gpa của sinh viên:");
                sv.Gpa = Convert.ToDouble(Console.ReadLine());
            } else {
                Console.WriteLine("Không tìm thấy sinh viên");
            }

        }
        public bool deleteStudentById(int id) {
            bool sucssesDelete = false;
            SinhVien sinhVien = findSudentById(id);
            if(sinhVien is not null) {
                listSinhVien.Remove(sinhVien);
                sucssesDelete = true;
            }
            return sucssesDelete;
        }
        public void sortByGpaAsc() {
             listSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                    return sv1.Gpa.CompareTo(sv2.Gpa);
            });
        }
        public void sortByNameAsc() {
            listSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                    return sv1.Name.CompareTo(sv2.Name);
            });
        }
        public void showStudents() {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5}",
                  "ID", "Name", "Age", "Address", "GPA");
            if (this.listSinhVien is not null  && listSinhVien.Count > 0)
            {
                foreach (SinhVien sv in this.listSinhVien)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5}",
                  sv.Id, sv.Name, sv.Age, sv.Address, sv.Gpa);
                }
            }
            Console.WriteLine();
        }
    }
}