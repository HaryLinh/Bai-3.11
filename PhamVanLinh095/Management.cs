using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanLinh095
{
    class Management
    {

        
        public void Save(ref List<HocSinh> ListHs, HocSinh hocSinh)
        {
            ListHs.Add(hocSinh);
        }
        public void ShowListHS(ref List<HocSinh> listHocSinh)
        {
            foreach (HocSinh hocSinh in listHocSinh)
            {
                Console.WriteLine(hocSinh.Xuat());
            }
        }
        public void SortListHocSinh(ref List<HocSinh> listHocSinh)
        {
            listHocSinh.Sort(
            delegate (HocSinh hs1, HocSinh hs2)
              {
                  int compareAvg = ((hs1.DiemH + hs1.DiemT + hs1.DiemL) / 3.0).CompareTo(((hs2.DiemH + hs2.DiemT + hs2.DiemL) / 3.0));

                  return compareAvg;
              }
          );

        }
    }
}
