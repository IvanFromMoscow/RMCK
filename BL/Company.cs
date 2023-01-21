using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BL
{
    [XmlRootAttribute("Company")]
    public class Company
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double OHZ { get;  set; }
        public double OPZ { get;  set; }
        public Company()
        {
            Id = 0;
            Name = null;
            Price = 0;
            OHZ = 0;
            OPZ = 0;
        }
        public Company(byte id, string name, decimal price, double OHZ, double OPZ)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.OHZ = OHZ;  
            this.OPZ = OPZ;
        }
        public override string ToString()
        {
            return String.Format("Company: {0}, {1}, {2}, {3:F2}, {4:F2}", Id, Name, Price, OHZ, OPZ);
        }
    }
}
