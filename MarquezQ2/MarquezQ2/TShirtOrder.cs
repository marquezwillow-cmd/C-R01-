//Willow Marquez
//wmarquez4@student.cnm.edu

using System;
//TShirtOrder.cs
//Programmer: Rob Garner (rgarner7@cnm.edu)
//Date: 10 Mar 2020
//Purpose: Model a TShirt order.
namespace TShirtOrders
{
    /// <summary>
    /// TShirtOrder
    /// Provides a model of a shirt order.
    /// </summary>
    public class TShirtOrder
    {
        //wm changed printAreaInSqIn to have default value of 0
        public TShirtOrder(string firstName = "", string lastName = "", string address = "", DateTime? orderDate = null, bool isLocalPickup = true, double printAreaInSqIn = 0, int numColors = 1, int numShirts = 1)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            OrderDate = orderDate;
            IsLocalPickup = isLocalPickup;
            this.printAreaInSqIn = printAreaInSqIn;
            this.numColors = numColors;
            this.numShirts = numShirts;
            Calc();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool IsLocalPickup { get; set; }
        private double printAreaInSqIn;
        public double PrintAreaInSqIn
        {
            get { return printAreaInSqIn; }
            set { printAreaInSqIn = value; Calc(); }
        }

        private int numColors;
        public int NumColors
        {
            //wm changed NumColors to numColors
            get { return numColors; }
            set { numColors = value; Calc(); }
        }

        private int numShirts;
        public int NumShirts
        {
            get { return numShirts; }
            set { numShirts = value; Calc(); }
        }
        //wm chancged { private get; set; } to {get; private set; }
        public decimal Price { get; private set; }
        private void Calc()
        {
            Price = (decimal)(numShirts * (numColors * 2.25 + printAreaInSqIn * .05));
        }
        public override string ToString()
        {
            return FirstName + " "
                + LastName + " "
                //wm added null 
                + (OrderDate.HasValue ? OrderDate.Value.ToString("MM/dd/yyyy HH:mm:ss") : "") + " "
                + " Price: " + Price.ToString("c");
        }
    }
}

