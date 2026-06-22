using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//aluminum sprocket
namespace MarquezP5._0
{
    public class AluminumSprocket : Sprocket
    {
        public AluminumSprocket() : base() { Calculate(); }

        public AluminumSprocket(string itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
            Calculate();
        }

        //calculate price
        protected override void Calculate()
        {
            Price = NumTeeth * NumItems * 0.04m;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Material: aluminum.";
        }
    }
}