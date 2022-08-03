using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    public static class TempConverter
    {
        public static double FarenheitToCelcius(double farenheit)
        {
            return (farenheit - 32) / 1.8;

        }
        public static double CelciusToFarenheit(double celcius)
        {
            return (celcius * 9) / 5 + 32;
        }
    }
}