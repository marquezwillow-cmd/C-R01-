//willow Marquez        
//wmarquez4@student.cnm.edu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    public class Assignment
    {
        public string Title { get; set; }
        private int score;

        public int Score
        {
            get { return score; }
            set 
            {
                //Validate list of scores pased in as value
                if (value >= 0 && value <= 100)
                {
                    score = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Scores must be between 0 and 100");
                }
            }
        }
        public override string ToString()
        {
            return Title + " " + score;
        }
    }
}
