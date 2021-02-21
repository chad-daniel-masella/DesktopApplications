using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsAppPredicateCalculator
{
    public class Data
    {
        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\AIE\Class\WindowsAppPredicateCalculator\Student.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(path);
        SqlCommand cmd;
        
        SqlDataReader reader;

        public void Save(Student Student)
        {
            conn.Open();
            string Query = "Insert into [Student](StudentID,StudentName,StudentClassTestOneMark,StudentClassTestTwoMark,StudentSemesterTestOneMark,StudentSemesterTestTwoMark,StudentPredicate,StudentRemarks)" +
                            "values('" + Student .getStudentNo() + "','" + Student.getStudentName() + "','" + Student.getStudentClassTest1() + "','" + Student.getStudentClassTest2() + "','" + Student.getStudentCemesterTest1() + "','" + Student.getStudentCemesterTest2() + "','" + Student.getStudentPredicate() + "','" + Student.Message() +  "')";
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand(Query, conn);
            adapter.InsertCommand = new SqlCommand(Query, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
    }
}
