using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        public Employee():this(-1, "TBD","TBD")
        {
            
        }
     
        public Employee(int empNum, string firstName, string lastName)
        {
            EmpNum = empNum;
            FirstName = firstName;
            LastName = lastName;
        }

        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //4.1Add the following method that overrides ToString() to Employee.cs:
        public override string ToString()
        {
            return EmpNum + " " + FirstName + " " + LastName;
        }

        public virtual string PaySummary
        {
            get { return "No pay"; }
        }

        private List<double> hours = new List<double>();

        public List<double> Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public virtual Decimal Pay(int start, int end)
        {
            return 0;
        }
    }
}
