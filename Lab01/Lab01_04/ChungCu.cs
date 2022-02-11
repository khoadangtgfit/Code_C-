using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    public class ChungCu:DiaOc
    {
        private int tang;
        public int Tang
        {
            get { return tang; }
            set { tang = value; }
        }
        public ChungCu()
        {

        }

        public ChungCu(string diadiem, double giaban, double dientich, int tang) : base(diadiem, giaban, dientich)
        {
            this.tang = tang;
        }
        public override void InPut()
        {
            base.InPut();
            Console.WriteLine("Nhập tầng:");
            Tang = int.Parse(Console.ReadLine());
        }
        public override string OutPut()
        {
            return base.OutPut()+" Tầng: "+Tang;
        }
    }
}
