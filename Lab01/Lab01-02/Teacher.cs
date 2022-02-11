using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher:Person
    {
        private string diachi;
        public string DiaChi
        {
            set
            {
                diachi = value;
            }
            get
            {
                return diachi;
            }
        }

        public Teacher(string diachi, string diaChi)
        {
            this.diachi = diachi;
            DiaChi = diaChi;
        }

        public Teacher() : base()
        {

        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập địa chỉ:");
            diachi = Console.ReadLine();
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(" Địa chỉ:{0}", diachi);
        }
    }
}
