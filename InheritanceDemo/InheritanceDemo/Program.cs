//willow marquez
//wmarquez4@student.cnm.edu
//LAB DEMO INHERITANCE

using InheritanceDemo;
using System;

namespace HRManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.3: Set up Base Class Instance
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";

            // 3.3: Set up Derived Class Instance
            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;

            // 5.1: Polymorphism Setup 
            Employee emp2 = hourEmp;

            // --- TESTING METHODS ---
            Console.WriteLine("=== 4.3 & 5.1: Method Execution ===");
            Console.WriteLine("emp.GetPaySummary: " + emp.GetPaySummary());
            Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.GetPaySummary());
            Console.WriteLine("emp2.GetPaySummary: " + emp2.GetPaySummary()); // Behaves differently based on override vs new
            Console.WriteLine("emp2.ToString(): " + emp2.ToString());
            Console.WriteLine("emp2.GetType(): " + emp2.GetType()); // Always returns HRManager.HourlyEmployee

            // --- TESTING VIRTUAL PROPERTIES ---
            Console.WriteLine("\n=== 7.3: Virtual Properties Execution ===");
            Console.WriteLine("emp.PaySummary: " + emp.PaySummary);
            Console.WriteLine("hourEmp.PaySummary: " + hourEmp.PaySummary);
            Console.WriteLine("emp2.PaySummary: " + emp2.PaySummary);

            // Keeps console active until a key is pressed
            Console.ReadLine();
        }
    }
}