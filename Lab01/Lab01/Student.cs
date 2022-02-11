using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab01
{
    public class Student
    {
        
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set {
                studentID = value;
             }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
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
        /// <summary>
        /// Constructor mặc định
        /// </summary>
        public Student()
        {
        }
        /// <summary>
        /// constructor có đối số
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="fullName"></param>
        /// <param name="averageScore"></param>
        /// <param name="faculty"></param>
        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }

        
        /// <summary>
        /// Hàm này để nhập
        /// </summary>
        public void Input()
        {
            Console.WriteLine("Nhập MSSV:");
            studentID = Console.ReadLine();
            Console.WriteLine("Nhập họ tên sinh viên:");
            fullName = Console.ReadLine();
            bool flag = false;
            do
            {
                flag = false;
                try
                {
                    Console.WriteLine("Nhập điểm TB:");
                    averageScore = float.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    flag = true;
                }
            } while (flag);
            Console.WriteLine("Nhập khoa:");
            faculty = Console.ReadLine();
        }
        /// <summary>
        /// Hàm này để xuất
        /// </summary>
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Họ Tên:{1} Điểm TB:{2} Khoa:{3}",
                this.studentID,this.fullName,this.averageScore,this.faculty);

        }

        
    }
}
