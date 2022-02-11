using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05;
using Microsoft.Reporting.WinForms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        Model1 Context = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> liststudent = Context.Students.ToList();
            List<Class1> listclass1 = new List<Class1>();
            foreach (Student item in liststudent)
            {
                Class1 class1 = new Class1();
                class1.StudentID = item.StudentID;
                class1.FullName = item.FullName;
                class1.FacultyName = item.Faculty.FacultyName;
                class1.AverageScore = item.AvarageScore;
                listclass1.Add(class1);
            }
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1",listclass1);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
