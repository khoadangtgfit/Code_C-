using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab01_04
{
    class Program
    {
        
        public static List<DiaOc> NhapDSDiaOc()
        {
            List<DiaOc> dsDiaOc = new List<DiaOc>();
            Console.WriteLine("Nhập số lượng địa ốc:");
            int n = int.Parse(Console.ReadLine());
            int chon = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập địa ốc thứ {0}", i + 1);
                Console.WriteLine("1.Nhập khu đất     2.Nhập chung cư        3.Nhập nhà phố");
                do
                {
                    Console.WriteLine("Mời chọn:");
                    chon = int.Parse(Console.ReadLine());
                    if (chon == 1)
                    {
                        DiaOc a = new KhuDat();
                        a.InPut();
                        dsDiaOc.Add(a);
                    }
                    if (chon == 2)
                    {
                        DiaOc a = new ChungCu();
                        a.InPut();
                        dsDiaOc.Add(a);
                    }
                    if (chon == 3)
                    {
                        DiaOc a = new NhaPho();
                        a.InPut();
                        dsDiaOc.Add(a);
                    }
                } while (chon != 1 && chon != 2 && chon != 3);

            }
            return dsDiaOc;
        }
        public static void XuatDSDiaOc(List<DiaOc> dsDiaOc)
        {
            foreach(DiaOc a in dsDiaOc)
            {
                if(a is KhuDat)
                {
                    Console.WriteLine("Khu đất :");
                    
                    Console.WriteLine( a.OutPut());
                }
                if (a is ChungCu)
                {
                    Console.WriteLine("Chung cư :");
                    Console.WriteLine( a.OutPut());
                }
                if (a is NhaPho)
                {
                    Console.WriteLine("Nhà phố :");
                    Console.WriteLine( a.OutPut());
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            List<DiaOc> dsDiaOc = new List<DiaOc>();
            //dsDiaOc= NhapDSDiaOc();
            Console.WriteLine("Danh sách địa ốc:");
            dsDiaOc.Add(new KhuDat() { DiaDiem = "Quận 9", GiaBan = 200, DienTich = 100 });
            dsDiaOc.Add(new KhuDat() { DiaDiem = "Hà nội", GiaBan = 30000000, DienTich = 9000000 });
            dsDiaOc.Add(new KhuDat() { DiaDiem = "Quảng Trị", GiaBan = 1200000, DienTich = 1 });
            dsDiaOc.Add(new KhuDat() { DiaDiem = "Sài Gòn", GiaBan = 120000000, DienTich = 1 });
            dsDiaOc.Add(new ChungCu() { DiaDiem = "Quận 9", GiaBan = 20000000, DienTich = 1000000,Tang=2 });
            dsDiaOc.Add(new ChungCu() { DiaDiem = "Quận 9", GiaBan = 20000000, DienTich = 1000000, Tang = 2 });
            dsDiaOc.Add(new ChungCu() { DiaDiem = "Quận 9", GiaBan = 20000000, DienTich = 1000000, Tang = 2 });
            dsDiaOc.Add(new ChungCu() { DiaDiem = "Quận 9", GiaBan = 20000000, DienTich = 1000000, Tang = 2 });
            dsDiaOc.Add(new NhaPho() { DiaDiem = "Quận 9", GiaBan = 188000002, DienTich = 28888, NamXayDung=new DateTime(2021,04,2) ,SoTang = 2 });
            dsDiaOc.Add(new NhaPho() { DiaDiem = "Quận 10", GiaBan = 20000000, DienTich = 1, NamXayDung = new DateTime(2030, 4, 1), SoTang = 2 });
            dsDiaOc.Add(new NhaPho() { DiaDiem = "Quận 11", GiaBan = 20000000, DienTich = 1000000, NamXayDung = new DateTime(2000, 4, 20), SoTang = 2 });
            dsDiaOc.Add(new NhaPho() { DiaDiem = "Sài gòn", GiaBan = 20000000, DienTich = 1000000, NamXayDung = new DateTime(2019, 4, 4), SoTang = 2 });
            XuatDSDiaOc(dsDiaOc);
            List<NhaPho> listNhaPho = new List<NhaPho>();
            List<ChungCu> listChungCu = new List<ChungCu>();
            List<KhuDat> listKhuDat = new List<KhuDat>();
            foreach (DiaOc a in dsDiaOc)
            {
                if (a is KhuDat)
                {
                    KhuDat i = a as KhuDat;
                    listKhuDat.Add(i);
                }
                if (a is ChungCu)
                {
                    ChungCu i = a as ChungCu;
                    listChungCu.Add(i);
                }
                if (a is NhaPho)
                {
                    NhaPho i = a as NhaPho;
                    listNhaPho.Add(i);
                }
            }
            Console.WriteLine("===============================================");
            
            double s = 0;
            foreach (DiaOc item in dsDiaOc)
            {
                s += item.GiaBan;
            }
            Console.WriteLine("Tổng giá bán cho 3 loại(khu đất, nhà phố,chung cư): "+s);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Danh sách khu đất có diện tích >100 hoặc nhà phố có diện tích > 60 và năm xây dựng >=2020:");
            List<DiaOc> dsresult = new List<DiaOc>();
            dsresult.AddRange(listKhuDat.Where(p=>p.DienTich>100).ToList());
            dsresult.AddRange(listNhaPho.Where(p => p.DienTich > 60 && p.NamXayDung.Year >= 2020));
            XuatDSDiaOc(dsresult);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Tìm kiếm danh sách khu đất theo điều kiện nhập vào:");
            string diadiem;
            double gia=0;
            double dientich=0;
            Console.WriteLine("Mời nhập thông tin tìm kiếm:");
            Console.WriteLine("-Nhập địa điểm :");
            diadiem = Console.ReadLine();
            bool flag1 = false;
            do
            {
                flag1 = false;
                try
                {
                    Console.WriteLine("Nhập giá:");
                    gia = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    flag1 = true;
                }
            } while (flag1);
            bool flag = false;
            do
            {
                flag = false;
                try
                {
                    Console.WriteLine("Nhập diện tích:");
                    dientich = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    flag = true;
                }
            } while (flag);
            List<DiaOc> result = new List<DiaOc>();
            result.AddRange(listKhuDat.Where(p => p.DiaDiem.Contains(diadiem,StringComparison.OrdinalIgnoreCase) && p.DienTich >= dientich && p.GiaBan <= gia).ToList());
            XuatDSDiaOc(result);
        }
    }
}
