// See https://aka.ms/new-console-template for more information
//Willow Marquez
//wmarquez4@student.cnm.edu
//MarquezQ1

using System;

namespace GForce
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            //header
            Console.WriteLine("===Gravitational Force Calculator===");
            //calculation loop
            do
            {
                //instantiate calc
                GForceCalculation gforceCalc = new GForceCalculation();

                //object 1
                Console.WriteLine("\nEnter the name of object 1(e.g, box): ");
                gforceCalc.Object1Name = Console.ReadLine();
                Console.WriteLine($"Enter the mass of {gforceCalc.Object1Name}in kg: ");
                gforceCalc.Mass1 = GetValidDouble();

                //object 2
                Console.WriteLine("\nEnter the name of object 2(e.g, bag): ");
                gforceCalc.Object2Name = Console.ReadLine();
                Console.WriteLine($"Enter the mass of {gforceCalc.Object2Name}in kg: ");
                gforceCalc.Mass2 = GetValidDouble();

                //distance
                Console.WriteLine($"Enter the distance between {gforceCalc.Object1Name} and {gforceCalc.Object2Name} in meters: ");
                gforceCalc.Radius = GetValidDouble();

                //display using overridden ToString
                Console.WriteLine("\nResult:");
                Console.WriteLine(gforceCalc.ToString());

                //play again
                Console.WriteLine("\n Would you like to calculate another force? (y/n): ");
                choice = Console.ReadLine().Trim().ToLower();
            }
            while (choice == "y" || choice == "yes");
            Console.WriteLine("Goodbye!");
        }

        //user inputs
        static double GetValidDouble()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result) || result <=0)
            {
                Console.WriteLine("Invalid input. Please enter a positive value: ");
            }
            return result;
        }
    }
    //calculation 
    public class GForceCalculation
    {
        //constant for gravity 
        private const double G = 6.67408e-11;

        //values
        private double _mass1;
        private double _mass2;
        private double _radius;
        private double _gforce;

        //auto properties
        public string Object1Name { get; set; }
        public string Object2Name { get; set; }

        //properties
        public double Mass1
        {
            get { return _mass1; }
            set { _mass1 = value;
                CalculateGForce();
            }
        }
        public double Mass2
        {
            get { return _mass2; }
            set
            {
                _mass2 = value;
                CalculateGForce();
            }
        }

        //calculate radius
        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                CalculateGForce();
            }
        }

        //read only property
        public double GForce
        {
            get { return _gforce; }
        }

        //calculate gforce F=G*(M1*M2)/r^2
        private void CalculateGForce()
        {
            //avoid dividing by 0
            if (_radius >0)
            {
                _gforce=G*(_mass1*_mass2)/Math.Pow(_radius,2);
            }
            else
            {
                _gforce = 0;
            }
        }

        //output 
        public override string ToString()
        {
            return $"The force between {Object1Name} and {Object2Name} is {GForce.ToString("e2")} Newtons.";
        }
        }
    }
