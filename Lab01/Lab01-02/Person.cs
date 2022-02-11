using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    public class Person
    {
        private string maso;
        private string hoten;
        public string MaSo
        {
            set
            {
                maso = value;
            }
            get
            {
                return maso;
            }
        }
        public string HoTen
        {
            set
            {
                hoten = value;
            }
            get
            {
                return hoten;
            }
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhập Mã số:");
            maso = Console.ReadLine();
            Console.WriteLine("Nhập họ tên:");
            hoten = Console.ReadLine();
        }
        public virtual void Show()
        {
            Console.Write("Mã số: {0} Họ tên:{1}", maso, hoten);
        }
    }
}
