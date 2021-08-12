using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class QL
    {
        List<SinhVien> SinhViens;

        public void NhapDS(int n)
        {
            SinhViens = new List<SinhVien>();

            for(int i = 0;i < n ; i++)
            {
                SinhVien SV = new SinhVien();

                SV.Input();

                SinhViens.Add(SV);
            }
        }

        public void XuatDS1()
        {
            int i = 1;
            foreach (SinhVien SV in SinhViens)
            {
                Console.WriteLine(i + "." + SV.Tostring());
                i++;
            }
        }

        public void XuatDS(List<SinhVien> SVs)
        {
            int i = 1;
            foreach(SinhVien SV in SVs)
            {
                Console.WriteLine( i+"."+ SV.Tostring());
                i++;
            }
        }

        public void XuatTheoKhoaCNTT()
        {
            List<SinhVien> SVs = SinhViens.Where(p => p.khoavien == "CNTT").ToList();

            XuatDS(SVs);
        }

        public void XuatSVDTBLonBang5()
        {
            List<SinhVien> SVs = SinhViens.Where(p => p.diemtb >= 5).ToList();

            XuatDS(SVs);
        }

        public void XuatDTBSVTangDan()
        {
            List<SinhVien> SVs = SinhViens.OrderBy(p => p.diemtb).ToList();

            XuatDS(SVs);
        }

        public void XuatSVDTBLonBang5ThuocCNTT()
        {
            List<SinhVien> SVs = SinhViens.Where(p => p.diemtb >= 5 && p.khoavien == "CNTT").ToList();

            XuatDS(SVs);
        }

        public void XuatSVDTBCaoNhatThuocCNTT()
        {
            List<SinhVien> SVs = SinhViens.Where(p => p.khoavien == "CNTT").ToList();

            SinhVien sv = SVs.OrderBy(p => p.diemtb).Last();

            Console.WriteLine(sv.Tostring());          
        }

        public void XuatSVDTBCaoNhatThuocCNTT2()
        {
            List<SinhVien> SVs = SinhViens.Where(p => p.khoavien == "CNTT").ToList();

            SinhVien Max = SVs[1];
            
            foreach(SinhVien sv in SVs)
            {
                if(sv.diemtb > Max.diemtb)
                {
                    Max = sv;
                }
            }

            Console.WriteLine(Max.Tostring());
        }
    }
}
