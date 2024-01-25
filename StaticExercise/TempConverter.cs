using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {

        public static double FahrenheitToCelsius(double fahr)
        {
            return (fahr - 32) * 5 / 9;
        }

        public static double CelsiusToFahernheit(double cels)
        {
            return (cels * 9 / 5) + 32;
        }

    }
}
