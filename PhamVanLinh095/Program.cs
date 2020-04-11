using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanLinh095
{
    class Program
    {
        static void Main(string[] args)
        {
             List<HocSinh> listHs = new List<HocSinh>();
             Management manager = new Management();
             Console.WriteLine("Hey my friend, Ban muon nhap bao nhieu sinh vien?");
             int soSinhVien = int.Parse(Console.ReadLine());

              for(int i = 0; i < soSinhVien; i++)
              {
                Console.WriteLine("Nhap ho ten:");
                string hoten = Console.ReadLine();
                Console.WriteLine("Nhap tuoi:");
                int tuoi = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem ly:");
                int diemLy = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem hoa:");
                int diemHoa = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem toan:");
                int diemToan = int.Parse(Console.ReadLine());
                HocSinh hocSinh = new HocSinh(hoten, tuoi, diemLy, diemHoa, diemToan);
                manager.Save(ref listHs, hocSinh);
              }
            Console.WriteLine("Thong tin danh sach hoc sinh:");
            Console.WriteLine("Ho ten\tTuoi\tDiemL\tDiemHoa\tDiemToan");
            manager.ShowListHS(ref listHs);
            Console.WriteLine("Danh sach hoc sinh co diem trung binh tang dan:");
            manager.SortListHocSinh(ref listHs);
            Console.WriteLine("Ho ten\tTuoi\tDiemL\tDiemHoa\tDiemToan");
            manager.ShowListHS(ref listHs);
            Console.ReadLine();

        }
    }
}
