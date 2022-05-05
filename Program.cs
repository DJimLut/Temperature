using System;
using static System.Console;

namespace Temperature
{
    class Program
    {
		// Methods that return the given value and unit of temperature in the requested unit of temperature
        public static double CelsiusToFahrenheit(double c)
        {
            return double.Parse(String.Format("{0:0.##}", (c * (9.0 / 5.0)) + 32));
        }

        public static double FahrenheitToCelsius(double f)
        {
            return double.Parse(String.Format("{0:0.##}", (f - 32) * 5.0 / 9.0));
        }

        public static void SwitchToFahrenheit(ref double c)
        {
            c = double.Parse(String.Format("{0:0.##}", (c * (9.0 / 5.0)) + 32));
        }

        public static void GetFahrenheitAndKelvin(double c, ref double f, ref double k)
        {
            f = double.Parse(String.Format("{0:0.##}", ((c * (9.0 / 5.0)) + 32)));
            k = double.Parse(String.Format("{0:0.##}", ((c + 273.15))));
        }

        public static void DisplayTemperature(double t, char ch)
        {
            WriteLine("***************************\nTemperature: " + t.ToString("F2") + "\x00B0" + ch + "\n***************************");
        }
		
        static void Main(string[] args)
        {
			// Initializing and declaring necessary variables
            double celsius = 30.0;
            double fahrenheit = 75.0;
            double kelvin = 313.10;

			// Passing the variables to their respective methods and outputting the value returned
            WriteLine(CelsiusToFahrenheit(celsius));
            WriteLine(FahrenheitToCelsius(fahrenheit));
            SwitchToFahrenheit(ref celsius);
            GetFahrenheitAndKelvin(celsius, ref fahrenheit, ref kelvin);

			// Formatting then displaying temperature
            DisplayTemperature(42.7, 'C');
            ReadKey();
        }
    }
}
