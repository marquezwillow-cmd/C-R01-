using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarquezP1
{
    public class LogoOrderItem
    {
        // Backing fields
        private bool hasLogo;
        private string itemType;
        private int numColors;
        private int numItems;
        private string text;

        // Auto property
        public int ItemID { get; set; }

        // Read-only auto property
        public decimal TotalPrice { get; private set; }

        // Properties
        ublic bool HasLogo
        {
            get { return hasLogo; }
            set
            {
                hasLogo = value;
                Calc();
            }
        }

        public string ItemType
        {
            get { return itemType; }
            set
            {
                itemType = value;
                Calc();
            }
        }

        public int NumColors
        {
            get { return numColors; }
            set
            {
                numColors = value;
                Calc();
            }
        }

        public int NumItems
        {
            get { return numItems; }
            set
            {
                numItems = value;
                Calc();
            }
        }

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                Calc();
            }
        }

        // Six parameter constructor
        public LogoOrderItem(int itemID,
                            string itemType,
                            int numColors,
                            int numItems,
                            string text,
                            bool hasLogo)
        {
            ItemID = itemID;
            this.itemType = itemType;
            this.numColors = numColors;
            this.numItems = numItems;
            this.text = text;
            this.hasLogo = hasLogo;

            Calc();
        }

        // Two parameter constructor
        public LogoOrderItem(string text, bool hasLogo)
            : this(-1, "mug", 0, 0, text, hasLogo)
        {
        }

        // Parameterless constructor
        public LogoOrderItem()
            : this(-1, "mug", 0, 0, "", false)
        {
        }

        // Calculate total price
        private void Calc()
        {
            decimal basePrice = 0m;
            if (!string.IsNullOrEmpty(itemType))
            {
                if (itemType.ToLower() == "pen")
                    basePrice = 1.00m;
                else if (itemType.ToLower() == "mug")
                    basePrice = 3.50m;
                else if (itemType.ToLower() == "usb")
                    basePrice = 4.00m;
            }

            decimal total = basePrice * numItems;

            //text
            if (!string.IsNullOrWhiteSpace(text))
            {
                total += 0.05m * numItems;
            }

            //logo
            if (hasLogo)
            {
                total += 0.10m * numItems;
                total += 0.03m * numColors * numItems;
            }

            TotalPrice = total;
        }


        public string GetOrderSummary()
        {
            if (hasLogo)
            {
                return $"Order num {ItemID}: {numItems} {itemType}s with {numColors} color logo with the following text: {text} Price: {TotalPrice:C}";
            }
            else
            {
                return $"Order num {ItemID}: {numItems} {itemType}s with text only: {text} Price: {TotalPrice:C}";
            }
        }
    }
}

