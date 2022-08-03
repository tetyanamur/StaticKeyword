using System;

namespace StaticKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var celcius =  TempConverter.CelciusToFarenheit(75);
            Console.WriteLine($"{celcius}");
            var farenheit = TempConverter.CelciusToFarenheit(30);
            Console.WriteLine($"{farenheit}");
        }
    }
}
