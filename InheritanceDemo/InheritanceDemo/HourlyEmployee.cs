using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        //3.2.	Add an HourlyEmployee class:

        public HourlyEmployee() : base()
        {
            HourlyRate = 15.0M;
        }
        //option a overriding sections 4,5,7
        // Use this setup to see Polymorphism in action.

        public override string GetPaySummary()
        {
            return "This employee is paid " + HourlyRate + " per hour";
        }

        public override string ToString()
        {
            // 1.2: Calling base class ToString() using the 'base' keyword
            return base.ToString() + " [Hourly Employee]";
        }

        //7.2.	Change GetPaySummary() into a property in HourlyEmployee.cs as well:
        public override string PaySummary
        {
            get { return "This employee is payed " + HourlyRate + " per hour"; }
        }
       
        // OPTION B: METHOD HIDING (Section 6)
      
        
        // to experience how method hiding breaks polymorphic behavior.
        /*
        new public string GetPaySummary()
        {
            return "This employee is paid " + HourlyRate + " per hour (Hidden)";
        }

        new public string ToString()
        {
            return base.ToString() + " [Hidden Hourly Employee]";
        }
        */
    }

}

