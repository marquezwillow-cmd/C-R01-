using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarquezP4
{
    // 1. Base Class: Straight Line Depreciation
    public class DepreciationStraightLine
    {
        // Fields backing properties
        private string _title;
        private DateTime _dateIn;
        private DateTime _dateOut;
        private decimal _startValue;
        private decimal _endValue;
        private int _lifetimeYears;

        public string Title
        {
            get => _title;
            set { _title = value; Calc(); }
        }

        public DateTime DateIn
        {
            get => _dateIn;
            set { _dateIn = value; Calc(); }
        }

        public DateTime DateOut
        {
            get => _dateOut;
            set { _dateOut = value; Calc(); }
        }

        public decimal StartValue
        {
            get => _startValue;
            set { _startValue = value; Calc(); }
        }

        public decimal EndValue
        {
            get => _endValue;
            set { _endValue = value; Calc(); }
        }

        public int LifetimeYears
        {
            get => _lifetimeYears;
            set { _lifetimeYears = value; Calc(); }
        }

        // Calculated property 
        public decimal CurrentDepreciatedValue { get; protected set; }

        // Constructor name now properly matches the class name!
        public DepreciationStraightLine()
        {
            _title = "New Item";
            _dateIn = DateTime.Now;
            _dateOut = DateTime.Now.AddYears(1);
            _startValue = 0;
            _endValue = 0;
            _lifetimeYears = 1;
            Calc();
        }

        // Calculates remaining value
        public virtual void Calc()
        {
            if (_lifetimeYears <= 0) return;

            // Straight line logic
            decimal totalDepreciableCost = _startValue - _endValue;
            decimal annualDepreciation = totalDepreciableCost / _lifetimeYears;

            // Calculate total depreciation based on the lifetime
            decimal totalDepreciationExpense = annualDepreciation * _lifetimeYears;

            CurrentDepreciatedValue = _startValue - totalDepreciationExpense;
        }

        public override string ToString()
        {
            return $"{Title} | Cost: {StartValue:C} | Salvage: {EndValue:C} | Life: {LifetimeYears} Yrs";
        }
    }
    public class DepreciationDoubleDeclining : DepreciationStraightLine
        {
            // Calc override 
            public override void Calc()
            {
                if (LifetimeYears <= 0) return;

                decimal straightLineRate = 1.0m / LifetimeYears;
                decimal doubleDecliningRate = 2.0m * straightLineRate;
                decimal currentBookValue = StartValue;

                // Process depreciation for each year
                for (int i = 0; i < LifetimeYears; i++)
                {
                    decimal depreciationExpense = currentBookValue * doubleDecliningRate;

                    if (currentBookValue - depreciationExpense < EndValue)
                    {
                        depreciationExpense = currentBookValue - EndValue;
                    }

                    currentBookValue -= depreciationExpense;
                    if (currentBookValue <= EndValue)
                    {
                        currentBookValue = EndValue;
                        break;
                    }
                }
                CurrentDepreciatedValue = currentBookValue;
            }

            public override string ToString()
            {
                return base.ToString() + " (Double Declining)";
            }
        }
    }
