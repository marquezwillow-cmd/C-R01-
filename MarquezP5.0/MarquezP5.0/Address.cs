using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarquezP5._0
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public override string ToString()
        {
            return $"{Street}\n{City} {State} {ZipCode}";
        }
    }
}
