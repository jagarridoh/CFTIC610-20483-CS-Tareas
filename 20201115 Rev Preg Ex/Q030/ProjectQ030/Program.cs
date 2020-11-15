using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ030
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio Q030");
            TempControl t = new TempControl();
            //var celsiusTemp = t.Temp();       // no compila
            var celsiusTemp = ((ICelsius)t).Temp();
            Console.WriteLine("celsiusTemp: {0}", celsiusTemp);
            var fahrenheitTemp = ((IFahrenheit)t).Temp();
            Console.WriteLine("fahrenheitTemp: {0}", fahrenheitTemp);
            Console.WriteLine("Fin Q030");
            Console.ReadKey();
        }
    }

    interface IFahrenheit
    {
        double Temp();
    }
    interface ICelsius
    {
        double Temp();
    }

    partial class TempControl : IFahrenheit, ICelsius
    {
        double kelvin;

        //public double ICelsius.Temp()    // No compila
        double ICelsius.Temp()
        {
            return getCelsiusFromKelvin();
        }

        double IFahrenheit.Temp()
        {
            return getFahrenheitFromKelvin();
        }

        double getCelsiusFromKelvin()
        {
            return -20;
        }
        double getFahrenheitFromKelvin()
        {
            return -40;
        }
    }
}
