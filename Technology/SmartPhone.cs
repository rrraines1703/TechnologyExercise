using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public double ScreenRes { get; set; }

        public SmartPhone(double screenRes, double ssd, string operatingSystem, double ram) : base(ssd, operatingSystem, ram)
        {
            ScreenRes = screenRes;
        }

        public string PhoneSpec()
        {
            return ("Wow! That phone has great resolution");
        }
    }
}
