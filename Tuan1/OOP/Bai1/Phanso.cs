using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1
{
    public class Phanso
    {
        public int Tuso {get; set;}
        public int Mauso {get; set;}

        public Phanso(){}

        public Phanso(int tuso, int mauso) {
            Tuso = tuso;
            Mauso = mauso;
        }
        public void inPhanSo() {
            Console.WriteLine($"{this.Tuso}/{this.Mauso}");
        }

        public Phanso congphanso(Phanso ph1, Phanso ph2)
        {
            Phanso ph3 = new Phanso();
            ph3.Tuso = ph1.Tuso * ph2.Mauso + ph2.Tuso * ph1.Mauso;
            ph3.Mauso = ph1.Mauso * ph2.Mauso;
 
            int uc = ucln(ph3.Tuso, ph3.Mauso);
            ph3.Tuso = ph3.Tuso / uc;
            ph3.Mauso = ph3.Mauso / uc;
 
            return ph3;
 
        }
        public int ucln(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        } 
    }
}