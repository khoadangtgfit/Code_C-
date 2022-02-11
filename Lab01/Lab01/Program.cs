using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab01
{
    class Program
    {
        /// <summary>
        /// Hàm này là hàm nhập danh sách
        /// </summary>
        /// <returns></returns>
        public static List<Student> NhapDSSV()
        {
            List<Student> DSSV = new List<Student>();
            
            Console.WriteLine("Nhập số lượng sinh viên:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nhập sinh viên thứ {0}",i+1);
                Student st = new Student();
                st.Input();
                DSSV.Add(st);
            }
            return DSSV;
        }
        /// <summary>
        /// Hàm này để xuất danh sách
        /// </summary>
        /// <param name="DSSV"></param>
        public static void XuatDSSV(List<Student> DSSV)
        {
            foreach(Student st in DSSV)
            {
                st.Show();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            List<Student> DSSV = new List<Student>();
            //Student st1 = new Student("111111", "Đặng Phước Khoa", 10, "CNTT");
            //DSSV.Add(st1);
            //Student st2 = new Student("222222", "Nguyễn thiện tâm", 3, "CNTT");
            //DSSV.Add(st2);
            //Student st3 = new Student("333333", "Nguyễn văn an", 5, "CNTT");
            //DSSV.Add(st3);
            //Student st4 = new Student("444444", "Lê văn Luyện", 4, "Tiếng Anh");
            //DSSV.Add(st4);
            //Student st5 = new Student("555555", "Dũng Trọc Hà Đông", 6, "Tài chính");
            //DSSV.Add(st5);
            //Student st6 = new Student("666666", "Đàm Vĩnh Biệt", 10, "CNTT");
            //DSSV.Add(st6);
            NhapDSSV();
            XuatDSSV(DSSV);
            Console.WriteLine("==========================================================");
            List<Student> dsSVCNTT = DSSV.Where(p => p.Faculty.Contains("CNTT")).ToList();
            if (dsSVCNTT.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào thuộc khoa CNTT");
            }
            else
            {
                Console.WriteLine("Các sinh viên thuộc khoa CNTT là:");
                XuatDSSV(dsSVCNTT);
            }
            Console.WriteLine("==========================================================");
            List<Student> dsresult = DSSV.Where(p => p.AverageScore > 5).ToList();
            if (dsresult.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào điểm trung bình > 5");
            }
            else
            {
                Console.WriteLine("Các sinh viên có điểm trung bình > 5:");
                XuatDSSV(dsresult);
            }
            Console.WriteLine("==========================================================");
            Console.WriteLine("Danh sách theo điểm trung bình tăng dần");
            List<Student> dsSort = DSSV.OrderBy(p => p.AverageScore).ToList();
            XuatDSSV(dsSort);
            Console.WriteLine("==========================================================");
            List<Student> Result = DSSV.Where(p => p.AverageScore > 5 && p.Faculty.Contains("CNTT")).ToList();
            XuatDSSV(Result);
            Console.WriteLine("==========================================================");
            List<Student> Result1 = DSSV.Where(p => p.Faculty.Contains("CNTT") && p.AverageScore == DSSV.Max(p => p.AverageScore)).ToList();
            {
                Console.WriteLine("Các sinh viên CNTT có điểm trung bình lớn nhất là:");
                XuatDSSV(Result1);
            }
        }
    }
}
