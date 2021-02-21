using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppPredicateCalculator
{
    public class Student
    {
        private long stdntNr;
        private string stnName;
        private double stdntCt1;
        private double stdntCt2;
        private double stdntSt1;
        private double stdntSt2;

        public Student(long s, string n, double Ct1, double Ct2, double St1, double St2)
        {
            this.stdntNr = s;
            this.stnName = n;
            this.stdntCt1 = Ct1;
            this.stdntCt2 = Ct2;
            this.stdntSt1 = St1;
            this.stdntSt2 = St2;
        }

        public long getStudentNo() { return stdntNr; }
        public string getStudentName() { return stnName; }
        public double getStudentCemesterTest1() { return stdntCt1; }
        public double getStudentCemesterTest2() { return stdntCt2; }
        public double getStudentClassTest1() { return stdntSt1; }
        public double getStudentClassTest2() { return stdntSt2; }

        public double getStudentPredicate()
        {
            return (getStudentClassTest1() * 0.2) + (getStudentClassTest2() * 0.2) + (getStudentCemesterTest1() * 0.3) + (getStudentCemesterTest1() * 0.3);
        }

        public string Message()
        {
            string message = null;

            if (getStudentPredicate() > 0 && getStudentPredicate() <= 39)
            {
                message = "You did not qualify to write the exam";
            }
            else if (getStudentPredicate() > 40 && getStudentPredicate() <= 74)
            {
                message = "You qualify to write an exam";
            }
            else if (getStudentPredicate() > 74 && getStudentPredicate() <= 100)
            {
                message = "You qualify with a distinction to write an exam";
            }

            return message;
        }

        public string View()
        {
            return "Student nr: " + getStudentNo() + "\nFull Name: " + getStudentName() + "\nClass Test One: " + getStudentClassTest1() +
                "\nClass Test Two: " + getStudentClassTest2() + "\nSemester Test One: " + getStudentCemesterTest1() + "\nSemester Test Two: " + getStudentCemesterTest2() +
                "\nPredicate: " + getStudentPredicate() + "\nRemarks: " + Message();
        }
    }
}
