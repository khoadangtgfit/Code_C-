using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    public class Student:Person
    {
       
        private float averageScore;
        private string faculty;

        public float AverageScore
        {
            get
            {
                return averageScore;
            }
            set
            {
                averageScore = value;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
        

        public Student( float averageScore, string faculty)
        {
            
            this.averageScore = averageScore;
            this.faculty = faculty;
        }
        public Student() : base()
        {

        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập điểm TB:");
            averageScore = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập khoa:");
            faculty = Console.ReadLine();
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(" Điểm TB:{0} Khoa:{1}", this.averageScore, this.faculty);

        }

    }
}
