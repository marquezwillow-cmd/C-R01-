using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarquezP5._0
{
    public class SprocketOrder
    {
        public string CustomerName { get; set; }
        public Address ShippingAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Sprocket> Items { get; private set; }

        // Parameterless constructor
        public SprocketOrder()
        {
            Items = new List<Sprocket>();
        }

        // 4-Parameter constructor variant (Customer, Address, explicit sublist initialization context)
        public SprocketOrder(string customerName, Address shippingAddress, List<Sprocket> items)
        {
            CustomerName = customerName;
            ShippingAddress = shippingAddress;
            Items = items ?? new List<Sprocket>();
            Calculate();
        }

        public void AddItem(Sprocket item)
        {
            Items.Add(item);
            Calculate();
        }

        public void RemoveItem(Sprocket item)
        {
            Items.Remove(item);
            Calculate();
        }

        private void Calculate()
        {
            TotalPrice = 0;
            foreach (var item in Items)
            {
                TotalPrice += item.Price;
            }
        }

        public override string ToString()
        {
            string addressString = ShippingAddress == null ? "Local Pickup" : $"Ship to:\n{ShippingAddress}";
            return $"{CustomerName}: {Items.Count} items\n Total Price: {TotalPrice:C}\n {addressString}\n";
        }
    }
}