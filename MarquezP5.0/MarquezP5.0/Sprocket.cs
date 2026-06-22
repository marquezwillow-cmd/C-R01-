//willow Marquez
//wmarquez@student.cnm.edu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarquezP5._0
{
    public abstract class Sprocket
    {
        // Backing fields for fully qualified properties
        private int _numItems;
        private int _numTeeth;

        public string ItemID { get; private set; }
        public decimal Price { get; protected set; }

        public int NumItems
        {
            get => _numItems;
            set
            {
                _numItems = value >= 0 ? value : throw new ArgumentException("Items cannot be negative.");
                Calculate();
            }
        }

        public int NumTeeth
        {
            get => _numTeeth;
            set
            {
                _numTeeth = value >= 0 ? value : throw new ArgumentException("Teeth cannot be negative.");
                Calculate();
            }
        }

        // Parameterless constructor
        public Sprocket()
        {
            ItemID = "UNKNOWN";
            NumItems = 0;
            NumTeeth = 0;
        }

        // Three-parameter constructor
        public Sprocket(string itemID, int numItems, int numTeeth)
        {
            ItemID = itemID;
            _numItems = numItems;
            _numTeeth = numTeeth;
        }

        // Abstract method to be overridden by custom materials
        protected abstract void Calculate();

        public override string ToString()
        {
            return $"Order num: {ItemID} Number: {NumItems} Teeth: {NumTeeth} Price: {Price:C}";
        }
    }
}