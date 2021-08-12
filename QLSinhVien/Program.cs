using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            QL ql = new QL();
            int chon = 0;
            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1.Tao DS.");
                Console.WriteLine("2.Xuat DS");
                Console.WriteLine("3.XuatTheoKhoaCNTT");
                Console.WriteLine("4.XuatSVDTBLonBang5");
                Console.WriteLine("5.XuatDTBSVTangDan");
                Console.WriteLine("6.XuatSVDTBLonBang5ThuocCNTT");
                Console.WriteLine("7.XuatSVDTBCaoNhatThuocCNTT");
                Console.Write("Chon: ");
                Console.WriteLine("----------------------------");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap so Sinh Vien trong DS: ");
                        int sl = int.Parse(Console.ReadLine());
                        ql.NhapDS(sl);
                        break;
                    case 2:
                        ql.XuatDS1();
                        break;
                    case 3:
                        
                        ql.XuatTheoKhoaCNTT();
                        break;
                    case 4:
                        ql.XuatSVDTBLonBang5();
                        
                        break;
                    case 5:
                        ql.XuatDTBSVTangDan();
                        break;
                    case 6:
                        ql.XuatSVDTBLonBang5ThuocCNTT();
                        break;
                    case 7:
                        ql.XuatSVDTBCaoNhatThuocCNTT2();
                        break;
                    default:
                        chon = 0;
                        break;
                }
                
            } while (chon != 0);          
        }
    }
}
