using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        //Change main to:
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            Console.WriteLine("emp.GetHashCode: " + emp.GetHashCode());
            Console.WriteLine("emp.GetType: " + emp.GetType());
            Console.WriteLine("emp.ToString: " + emp.ToString());

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;
            Console.WriteLine("hourEmp.GetHashCode: " + hourEmp.GetHashCode());
            Console.WriteLine("hourEmp.GetType: " + hourEmp.GetType());
            Console.WriteLine("hourEmp.ToString: " + hourEmp.ToString());

            
            //5.1 Boxing
            Object athing = hourEmp;
            Console.WriteLine("hourEmp.ToString: " + athing);

        }


    }
}
