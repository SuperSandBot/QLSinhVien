using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class Person
    {
        private string Hoten;
        private int Ms;
        public string hoten { get => Hoten; set => Hoten = value; }
        public int ms { get => Ms; set => Ms = value; }

        public Person()
        {

        }

        public Person(string hoten, int ms)
        {
            Hoten = hoten;
            Ms = ms;
        }

        public virtual void Input()
        {
            Console.Write("Nhap Hoten SV: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap Mssv: ");
            Ms = int.Parse(Console.ReadLine());
        }
        public virtual string Tostring()
        {
            return "Hoten: " + Hoten + " ,Mssv: " + Ms;
        }
    }
}
}
