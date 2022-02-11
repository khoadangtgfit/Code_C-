using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    public class NhaPho:DiaOc
    {
        private DateTime namxaydung;
        private int sotang;
        public DateTime NamXayDung
        {
            get { return namxaydung; }
            set { namxaydung = value; }
        }
        public int SoTang
        {
            get { return sotang; }
            set { sotang = value; }
        }
        public NhaPho()
        {

        }
        public NhaPho(string diadiem, double giaban, double dientich, DateTime namxaydung, int sotang) : base(diadiem, giaban, dientich)
        {
            this.namxaydung = namxaydung;
            this.sotang = sotang;
        }
        public override void InPut()
        {
            base.InPut();
            bool flag ;
            do
            {
                flag = false;
                try
                {
                    Console.WriteLine("Nhập năm xây dựng(Ngay/Thang/Nam):");
                    string s = Console.ReadLine();
                    NamXayDung = DateTime.Parse(s);
                }
                catch (Exception e)
                {
                    flag = true;
                }
            } while (flag);
            Console.WriteLine("Nhập số tầng:");
            SoTang = int.Parse(Console.ReadLine());
        }
        public override string OutPut()
        {
            return base.OutPut()+" Năm xây dựng: "+NamXayDung.ToString("dd/MM/yyyy")+" Số tầng: "+SoTang;
        }
    }
}
