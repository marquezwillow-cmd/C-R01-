//Willow marquez
//wmarquez4@student.cnm.edu
//IdealGasCalcUsingClass
//5/31/26

using IdealGasCalcUsingClass;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace IdealGasCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gasNames = new string[100];
            double[] molecularWeights = new double[100];
            int count = 0;

            DisplayHeader();

            try
            {
                GetMolecularWeights(ref gasNames, ref molecularWeights, out count);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading gas data file:{ex.Message}");
                return;
            }
            DisplayGasNames(gasNames, count);
            string choice;

            do
            {
                try
                {
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine("Enter the name of the gas: ");
                    string userGas = Console.ReadLine();

                    //get mol weight
                    double molWeight = GetMolecularWeightFromName(userGas, gasNames, molecularWeights, count);
                    //if gas not found display error
                    if (molWeight == -1.0)
                    {
                        Console.WriteLine($"Error: Gas '{userGas}' was not found. Please try again.");
                    }
                    //instantiate target object modle
                    IdealGas gas = new IdealGas();
                    gas.SetMolecularWeight(molWeight);

                    //user inputs

                    //inputs
                    Console.WriteLine("enter the volume of the gas container in cubic meters: ");
                    double volume = Convert.ToDouble(Console.ReadLine());
                    gas.SetVolume(volume);

                    Console.WriteLine("Enter the mass (weight) of the gas (grams): ");
                    double mass = Convert.ToDouble(Console.ReadLine());
                    gas.SetMass(mass);

                    Console.WriteLine("Enter the temprature of the gas in Celsius: ");
                    double temprature = Convert.ToDouble(Console.ReadLine());
                    gas.SetTemprature(temprature);

                    //display
                    DisplayPresure(gas.GetPressure());
                }
                //structured catch strategies
                catch (FormatException)
                {
                    Console.WriteLine("Input Processing Error: Enterd value was not valid");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input range Error: Number size exceeds limits.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected System Error: {ex.Message}");
                }
                finally
                {
                    Console.Write("\nWould you like to calculate another gas? (y/n): ");
                    choice = Console.ReadLine().Trim().ToLower();
                }

            } while (choice == "y" || choice == "yes");

            // Goodbye 
            Console.WriteLine("\nThank you for using the Ideal Gas Pressure Calculator! Goodbye.");
        }
        //header
        static void DisplayHeader()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("        Programmer:            ");
            Console.WriteLine(" Title: Ideal Gas Law Preassure Calculator ");
            Console.WriteLine(" Objective: Calculate the preasure of gas  ");
            Console.WriteLine("  given its volume, mass, and temprature.  ");
        }
        static void GetMolecularWeights(ref string[] gasNames, ref double[] molecularWeights, out int count)
        {
            string fileName = "Mols.csv";
            count = 0;
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"The file '{fileName}' was not found.");
            }
            using (StreamReader reader = new StreamReader(fileName))
            {
                //skip header
                string headerline = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        gasNames[count] = parts[0].Trim();
                        molecularWeights[count] = Convert.ToDouble(parts[1].Trim());
                        count++;
                    }
                }
            }
        }
        //array display gas names
        private static void DisplayGasNames(string[] gasNames, int countGases)
        {
            Console.WriteLine("Available Gases");
            Console.WriteLine("---------------");
            for (int i = 0; i < countGases; i++)
            {
                //format 
                Console.Write($"{gasNames[i],-20}");

                //new line every 3 items
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
            //new line final row
            if (countGases % 3 != 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");
        }
        //look up gas name returns weight
        private static double GetMolecularWeightFromName(string gasName, string[] gasNames, double[] molecularWeights, int countGases)
        {
            for (int i = 0; i < countGases; i++)
            {
                if (gasNames[i].Equals(gasName, StringComparison.OrdinalIgnoreCase))
                {
                    return molecularWeights[i];
                }
            }
            return -1.0;//value not found
        }
        private static void DisplayPresure(double pressure)
        {
            Console.WriteLine("\nCalculation Results: ");
            Console.WriteLine($"Pressure in Pascals: {pressure:N2} Pa");
            Console.WriteLine($"Pressure in PSI:     {PaToPSI(pressure):N4} PSI");
        }

        static double PaToPSI(double pascals)
        {
            return pascals * 0.0001450377373;
        }
    }
}