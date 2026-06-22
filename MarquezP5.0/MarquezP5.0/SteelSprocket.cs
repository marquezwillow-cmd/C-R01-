using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//steel sprocket
namespace MarquezP5._0
{
    public class SteelSprocket : Sprocket
    {
        public SteelSprocket() : base() { Calculate(); }

        public SteelSprocket(string itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
            Calculate();
        }

        //calculate price
        protected override void Calculate()
        {
            Price = NumTeeth * NumItems * 0.05m;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Material: steel.";
        }
    }
}
