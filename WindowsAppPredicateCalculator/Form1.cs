using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppPredicateCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            long StudentNo = long.Parse(StdntNo.Text);
            string StudentName = StdntFullName.Text;
            float StudentClassTestOne = long.Parse(StdntClassTestOne.Text);
            float StudentClassTestTwo = long.Parse(StdntClassTestTwo.Text);
            float StudentSemesterTestOne = long.Parse(StdntSemesterTestOne.Text);
            float StudentSemesterTestTwo = long.Parse(StdntSemesterTestTwo.Text);

            Student Student = new Student(StudentNo, StudentName, StudentSemesterTestOne, StudentSemesterTestTwo, StudentClassTestOne, StudentClassTestTwo);
            FormDisplayData.Text = Student.View();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            long StudentNo = long.Parse(StdntNo.Text);
            string StudentName = StdntFullName.Text;
            float StudentClassTestOne = long.Parse(StdntClassTestOne.Text);
            float StudentClassTestTwo = long.Parse(StdntClassTestTwo.Text);
            float StudentSemesterTestOne = long.Parse(StdntSemesterTestOne.Text);
            float StudentSemesterTestTwo = long.Parse(StdntSemesterTestTwo.Text);

            Student Student = new Student(StudentNo, StudentName, StudentClassTestOne, StudentClassTestTwo, StudentSemesterTestOne, StudentSemesterTestTwo);

            Data data = new Data();
            data.Save(Student);
        }

        private void View_Click(object sender, EventArgs e)
        {

        }

        private void StdntNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void StdntFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StdntClassTestOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void StdntClassTestTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void StdntSemesterTestOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void StdntSemesterTestTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
