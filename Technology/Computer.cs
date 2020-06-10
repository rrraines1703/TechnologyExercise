using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer
    {
        public double Ssd { get; set; }
        public string OperatingSystem { get; set; }
        public double Ram { get; set; }

        public Computer(double ssd, string operatingSystem, double ram)
        {
            Ssd = ssd;
            OperatingSystem = operatingSystem;
            Ram = ram;
        }

        public string YourComputer()
        {
            return ("Thats a nice one!");
        }
    }
}
