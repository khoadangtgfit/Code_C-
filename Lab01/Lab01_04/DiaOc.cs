using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    public class DiaOc
    {
        private string diadiem;
        private double giaban;
        private double dientich;

        public DiaOc()
        {

        }
        public DiaOc(string diadiem, double giaban, double dientich)
        {
            this.diadiem = diadiem;
            this.giaban = giaban;
            this.dientich = dientich;
        }

        public string DiaDiem
        {
            get { return diadiem; }
            set { diadiem = value; }
        }
        public double GiaBan
        {
            get { return giaban; }
            set { giaban = value; }
        }
        public double DienTich
        {
            get { return dientich; }
            set { dientich = value; }
        }
        public virtual void InPut()
        {
            Console.WriteLine("Nhập địa điểm:");
            DiaDiem = Console.ReadLine();
            Console.WriteLine("Nhập giá bán:");
            GiaBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập diện tích:");
            DienTich = double.Parse(Console.ReadLine());
        }
        public virtual string OutPut()
        {
            return "Địa điểm: " + DiaDiem + " Giá bán: " + GiaBan + " Diện tích: " + DienTich;
        }
    }
}
