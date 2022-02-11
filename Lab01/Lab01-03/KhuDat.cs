using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    public class KhuDat
    {
        private string diadiem;
        private float giaban;
        private float dientich;
        public string DiaDiem
        {
            set { diadiem = value; }
            get { return diadiem; }
        }
        public float GiaBan
        {
            set { giaban = value; }
            get { return giaban; }
        }
        public float DienTich
        {
            set { dientich = value; }
            get { return dientich; }
        }

        public KhuDat()
        {
        }

        public KhuDat(string diadiem, float giaban, float dientich)
        {
            this.diadiem = diadiem;
            this.giaban = giaban;
            this.dientich = dientich;
        }
        public void Input()
        {
            Console.WriteLine("Nhập địa điểm:");
            diadiem = Console.ReadLine();
            Console.WriteLine("Nhập giá bán:");
            giaban = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập diện tích:");
            dientich= float.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Địa điểm: " + this.diadiem + " Giá bán:" + this.giaban+" Diện tích: "+this.dientich;
        }
    }
}
