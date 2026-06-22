//Willow Marquez
//wmarquez4@student.cnm.edu

// Class: StudentClassDemo.Student.cs
// Programmer: Rob Garner (rgarner7@cnm.edu)
// Date: 20161003
// Purpose: Holds information for one student

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WpfDemo
{
    class Student
    {
        #region Properties
        //wm The name property can be a simple auto property... no validation needed
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        
        // wm Output calculated runtime property accessible externally but safe from UI overrides
        public double Average { get; private set; }

        //wm Backing reference list changing from List<int> to List<Assignment>
        private List<Assignment> scores;

        //wm Public structural list wrapper managing internal calculations
        public List<Assignment> Scores
        {
            get { return scores; }
            set 
            {
                bool isValid = true;
                foreach(Assignment item in value)
                {
                    // wm Validation loop processing nested elements securely
                    isValid = isValid && item.Score >= 0 && item.Score <= 100;
                }
                
                if (isValid) 
                {
                    scores = value; 
                    // wm Call calculate method if value affects other fields
                    CalcAverage(); 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Scores must be between 0 and 100");
                }
            }
        }
        #endregion

        #region Constructors
        public Student()
            : this("Number Pending", "TBD", "TBD", "Undeclared")
        {
        }

        public Student(string sID)
            : this(sID, "TBD", "TBD", "Undeclared")
        {
        }

        // wm  class  add the following to our main constructor"
        //  stops the application from throwing NullReferenceExceptions when interacting with values.
        public Student(string sID, string firstName, string lastName, string maj)
        {
            StudentNumber = sID;
            FirstName = firstName;
            LastName = lastName;
            Major = maj;
            
            //wm This instantiates the list each time we instantiate a new student object
            scores = new List<Assignment>(); 
        }

        public Student(string sID, string firstName, string lastName, string maj, List<Assignment> scores)
            : this(sID, firstName, lastName, maj)
        {
            this.scores = scores;
            CalcAverage();
        }
        #endregion

        #region Instance Methods
        //wm change the CalculateAverage method to process Assignment objects
        public void CalcAverage()
        {
            // wm Prevents crashing from a DivideByZeroException if no scores are entered yet
            if (scores == null || scores.Count == 0)
            {
                Average = 0;
                return;
            }

            double sum = 0;
            foreach (Assignment assignment in scores)
            {
                // wm Have to get the numeric score from its Score property
                sum += assignment.Score;
            }
            Average = sum / scores.Count;
        }

        // wm  Object formatting conversion utilized by UI elements for presentation
        public override string ToString()
        {
            return FirstName + " " + LastName
                + " | Major: " + Major
                + " | Average: " + Average.ToString("f2");
        }
        #endregion
    }
}