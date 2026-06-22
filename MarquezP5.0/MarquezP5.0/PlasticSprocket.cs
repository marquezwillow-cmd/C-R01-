using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//plastic sprocket
namespace MarquezP5._0
{
    public class PlasticSprocket : Sprocket
    {
        public PlasticSprocket() : base() { Calculate(); }

        public PlasticSprocket(string itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
            Calculate();
        }

        //calculate price
        protected override void Calculate()
        {
            Price = NumTeeth * NumItems * 0.02m;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Material: plastic.";
        }
    }
}