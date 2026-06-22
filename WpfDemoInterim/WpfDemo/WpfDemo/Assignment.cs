using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDemo
{
    public class Assignment
    {
        //wm Composability" Auto-Property to hold specific names for scores
        public string Title { get; set; }

        private int score;

        // wm Validated Score Property
        public int Score
        {
            get { return score; }
            set
            {
                // wm Inspect value coming in to make sure it's valid
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

        // wm ListBoxes use the ToString() method to figure out what to display
        // Overriding this ensures the UI layout presents meaningful text rather than its class name.
        public override string ToString()
        {
            return $"{Title} - Score: {score}";
        }
    }
}