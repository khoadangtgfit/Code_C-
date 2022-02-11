using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab01_02
{
    class Program
    {
        public static List<Person> NhapDSPerSon()
        {
            List<Person> DSPerSon = new List<Person>();
            Console.WriteLine("Nhập số người:");
            int n = int.Parse(Console.ReadLine());
            int chon = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập người thứ {0}", i + 1);
                Console.WriteLine("1.Nhập Sinh Viên     2.Nhập Giảng Viên");
                do
                {
                    Console.WriteLine("Mời chọn:");
                    chon = int.Parse(Console.ReadLine());
                    if (chon == 1)
                    {
                        Person st = new Student();
                        st.Input();
                        DSPerSon.Add(st);
                    }
                    if (chon == 2)
                    {
                        Person tc = new Teacher();
                        tc.Input();
                        DSPerSon.Add(tc);
                    }
                } while (chon!=1&&chon!=2);
            }
            return DSPerSon;
        }
        public static void XuatDSPerSon(List<Person> DSPerSon)
        {
            foreach(Person ps in DSPerSon)
            {
                ps.Show();
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<Person> DSPerSon = new List<Person>();
            //DSPerSon = NhapDSPerSon();

            DSPerSon.Add(new Student() { MaSo = "12345", HoTen = "Đặng Phước Khoa", AverageScore = 10, Faculty = "CNTT" });
            DSPerSon.Add(new Teacher() { MaSo = "12321", HoTen = "Đàm Vĩnh Biệt", DiaChi = "Hùng Vương" });
            DSPerSon.Add(new Student() { MaSo = "1344", HoTen = "Nguyễn văn Tèo", AverageScore = 1, Faculty = "CNTT" });
            DSPerSon.Add(new Student() { MaSo = "13345", HoTen = "Trấn Thành", AverageScore = 1, Faculty = "Hài" });
            DSPerSon.Add(new Teacher() { MaSo = "1sss21", HoTen = "Đàm Vĩnh Long", DiaChi = "Quận 9" });
            DSPerSon.Add(new Teacher() { MaSo = "1s321", HoTen = "Đàm Vĩnh Hưng", DiaChi = "Hùng Vương" });
            DSPerSon.Add(new Teacher() { MaSo = "CN", HoTen = "Đàm Vĩnh Cửu", DiaChi = "Hùng Vương" });
            List<Student> DSStudent = new List<Student>();
            List<Teacher> DSTeacher = new List<Teacher>();
            XuatDSPerSon(DSPerSon);

            foreach (Person i in DSPerSon)
            {
                if(i is Student)
                {
                    Student t= i as Student;
                    DSStudent.Add(t);
                }
                if(i is Teacher)
                {
                    Teacher t = i as Teacher;
                    DSTeacher.Add(t);
                }
            }
            Console.WriteLine("============================================================");
            List<Student> SVCNTT = DSStudent.Where(p => p.Faculty.Contains("CNTT")).ToList();
            if (SVCNTT.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào thuộc khoa CNTT trong danh sách!!!");
            }
            else
            {
                Console.WriteLine("==>Danh sách sinh viên thuộc khoa CNTT trong danh sách:");
                foreach (Student i in SVCNTT)
                {
                    i.Show();
                }
            }
            Console.WriteLine("============================================================");
            List<Student> ListResult = DSStudent.Where(p => p.AverageScore < 5 && p.Faculty.Contains("CNTT")).ToList();
            if (ListResult.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào thuộc khoa CNTT và điểm trung bình dưới 5 trong danh sách!!!");
            }
            else
            {
                Console.WriteLine("==>Danh sách sinh viên thuộc khoa CNTT và điểm TB < 5 trong danh sách:");
                foreach (Student i in ListResult)
                {
                    i.Show();
                }
            }
            Console.WriteLine("============================================================");
            List<Teacher> ListResult1 = DSTeacher.Where(p => p.DiaChi.Contains("Quận 9")).ToList();
            if (ListResult1.Count == 0)
            {
                Console.WriteLine("Không có giảng viên nào có địa chỉ là Quận 9!!!");
            }
            else
            {

                foreach (Teacher i in ListResult1)
                {
                    i.Show();
                }
            }
            Console.WriteLine("============================================================");
            List<Teacher> ListResult2 = DSTeacher.Where(p => p.MaSo.CompareTo("CN") == 0).ToList();
            if (ListResult2.Count == 0)
            {
                Console.WriteLine("Không có giảng viên nào có mã CN trong danh sách!!!");
            }
            else
            {
                Console.WriteLine("==>Danh sách giảng viên có mã CN:");
                foreach (Teacher i in ListResult2)
                {
                    i.Show();
                }
            }
            Console.WriteLine("============================================================");
            List<Student> ListResult3 = DSStudent.Where(p => p.Faculty.Contains("CNTT") && p.AverageScore == DSStudent.Max(p => p.AverageScore)).ToList();
            foreach (Student i in ListResult3)
            {
                i.Show();
            }
            List<Person> DiemTBCN = DSPerSon.Where(stu => (stu as Student).Faculty == "CNTT").Where(stu => (stu as Student).AverageScore == DSPerSon.Max(p => (p as Student).AverageScore)).ToList();
            Console.WriteLine("=========================dd===================================");
            foreach (Student i in DiemTBCN)
            {
                i.Show();
            }
        }
    }
}
