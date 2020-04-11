using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanLinh095
{
    class HocSinh
    {
        private string _HoTen;

        private int _Tuoi;

        private int _DiemT;

        private int _DiemL;

        private int _DiemH;

        public string HoTen { get => _HoTen; set => _HoTen = value; }

        public int Tuoi { get => _Tuoi; set => _Tuoi = value; }

        public int DiemL { get => _DiemL; set => _DiemL = value; }

        public int DiemH { get => _DiemH; set => _DiemH = value; }

        public int DiemT { get => _DiemT; set => _DiemT = value; }

        public HocSinh()
        {
        }

        public HocSinh(string hoTen, int tuoi, int diemL, int diemH, int diemT)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            DiemL = diemL;
            DiemH = diemH;
            DiemT = diemT;
        }

        public void Nhap(string hoTen, int tuoi, int diemT, int diemL, int diemHoa)
        {
            this.HoTen = hoTen; ;
            this.Tuoi = tuoi;
            this.DiemT = diemT;
            this.DiemL = diemL;
            this.DiemH = DiemH;
        }
        public String Xuat()
        {
           return String.Format ("{0}\t{1}\t{2}\t{3}\t{4}", this.HoTen, this.Tuoi, this.DiemT, this.DiemL, this.DiemH);
        }
    }
}
