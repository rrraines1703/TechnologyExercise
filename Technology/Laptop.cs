using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public bool TouchScreen { get; set; } = false;

        public Laptop(bool touchScreen, double ssd, string operatingSystem, double ram) : base(ssd, operatingSystem, ram)
        {
            TouchScreen = touchScreen;
        }

        public string ThatsCool()
        {
            return "That is a cool one";
        }

    }
}
