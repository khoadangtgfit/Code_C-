using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab01_03
{
    class Program
    {
        public static List<KhuDat> NhapDSKhuDat()
        {
            List<KhuDat> DSKhuDat = new List<KhuDat>();
            Console.WriteLine("Nhập số khu đất:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập khu đất thứ {0}", i + 1);
                KhuDat kd = new KhuDat();
                kd.Input();
                DSKhuDat.Add(kd);
            }
            return DSKhuDat;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<KhuDat> DSKhuDat = new List<KhuDat>();
            //DSKhuDat = NhapDSKhuDat();
            DSKhuDat.Add(new KhuDat() {DiaDiem="200 Hùng Vương",GiaBan= 234,DienTich= 2234 });
            DSKhuDat.Add(new KhuDat() { DiaDiem = "3000 Phạm Văn Đồng", GiaBan = 2000000000000000, DienTich = 22 });
            DSKhuDat.Add(new KhuDat() { DiaDiem = "2020 Hùng Vương", GiaBan = 123453456, DienTich = 801 });
            DSKhuDat.Add(new KhuDat() { DiaDiem = "200 Hùng Vương", GiaBan = 333, DienTich = 100 });
            DSKhuDat.Add(new KhuDat() { DiaDiem = "200 Hùng Vương", GiaBan = 3111111, DienTich = 2222 });
            Console.WriteLine("=====================================================");
            DSKhuDat.OrderBy(p => p.DienTich).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("=====================================================");
            DSKhuDat.Where(p => p.GiaBan < 1000000000 && p.DienTich >= 60).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("=====================================================");
            //var teo = from s in DSKhuDat
            //          where s.DienTich > 10
            //          select new
            //          {
            //              ten = s.DienTich
            //          };
            //teo.ToList().ForEach(p => Console.WriteLine(p.ten));
            var ty = from t in DSKhuDat
                     where t.DienTich > 1000
                     select new
                     {
                         DiaDiem = t.DiaDiem,
                         GiaBan = t.GiaBan,
                         DienTich = t.DienTich,
                         GiaTrungBinh = t.GiaBan / t.DienTich
                     };
            ty.ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
