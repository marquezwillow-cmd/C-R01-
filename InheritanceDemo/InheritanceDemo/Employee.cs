using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        //3.1.	Add an Employee class
        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //4.1.	Add the following method to the Employee class:
        public virtual string GetPaySummary()
        {
            return "No pay for base class employee.";
        }

        //7.1.	Change GetPaySummary() into a property in Employee.cs:
        public virtual string PaySummary
        {
            get { return "No pay for base class employee."; }
        }

        //override
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {EmpNum})";
        }
    }

}
