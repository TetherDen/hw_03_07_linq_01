using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_07_linq_01
{
    internal class Device
    {
        public string DeviceName {  get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public Device(string deviceName, string manufacturer, double price)
        {
            DeviceName = deviceName;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {DeviceName}, Price: {Price}, Manufacturer: {Manufacturer}";
        }
    }
}
