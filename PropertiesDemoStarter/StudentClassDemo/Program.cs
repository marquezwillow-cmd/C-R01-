using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.Major = "Computer Programming";
            myStudent.Score1 = 80;
            myStudent.Score2 = 90;
            myStudent.Score3 = 95;

            Student myOtherStudent = new Student();
            myOtherStudent.Major = "Art History";
            myOtherStudent.Score1 = 90;
            myOtherStudent.Score2 = 90;
            myOtherStudent.Score3 = 95;

            Console.WriteLine("My Major is {0} average is {1}", myStudent.Major, myStudent.Average);          
            Console.WriteLine("The other student's major is {0} average is {1}.", myOtherStudent.Major, myOtherStudent.Average);
        }
    }
}
