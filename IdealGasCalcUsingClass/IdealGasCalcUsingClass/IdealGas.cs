using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealGasCalcUsingClass
{
    internal class IdealGas
    {
        //data members
        private double mass;
        private double volume;
        private double temp;
        private double molecularWeight;
        private double pressure;

        //constant
        private const double R = 8.3145;

        //Constructor initalize empty default values
        public IdealGas()
        {
            this.mass = 0.0;
            this.volume = 0.0;
            this.temp = 0.0;
            this.molecularWeight = 0.0;
            this.pressure = 0.0;
        }

        //mass methods
        public void SetMass(double value)
        {
            this.mass = value;
            Calc();
        }
        public double GetMass()
        {
            return this.mass;
        }

        //volume
        public void SetVolume(double value)
        {
            this.volume = value;
            Calc();
        }
        public double GetVolume()
        {
            return this.volume;
        }

        //temp
        public void SetTemprature(double value)
        {
            this.temp = value;
            Calc();
        }
        public double GetTemperature()
        {
            return this.temp;
        }

        //molecular weight 
        public void SetMolecularWeight(double value)
        {
            this.molecularWeight = value;
            Calc();
        }
        public double GetMolecularWeight()
        {
            return this.molecularWeight;
        }

        //pressure
        public double GetPressure()
        {
            return (this.pressure);
        }

        //private parameterless calc
        private void Calc()
        {
            if (this.molecularWeight == 0 || this.volume == 0)
            {
                this.pressure = 0;
                return;
            }
            //calculate moles n=mazz/ molecular weight
            double n = this.mass / this.molecularWeight;

            //convert temp C to T T=C+273.15
            double T = this.temp + 273.15;

            //ideal gas equation P=(n*R*T)/v
            this.pressure = (n * R * T) / this.volume;
        }
    }
}