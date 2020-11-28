using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ136
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Partner();
            p.TotalPrice = 1001;
            Console.WriteLine($"caso Partner 1001: {getDiscount(p)}.");
            p.TotalPrice = 1000;
            Console.WriteLine($"caso Partner 1000: {getDiscount(p)}.");
            var v = new Vendor();
            v.TotalPrice = 100;
            Console.WriteLine($"caso Vendor: {getDiscount(v)}.");
            Console.WriteLine($"caso null: {getDiscount(null)}.");
        }

        public static double getDiscount(Vendor vendor)
        {
            switch (vendor)
            {
                // LINEA 05 Insertar programación aquí
                //Code Block 2
                case Partner p when p.TotalPrice <= 1000:
                    return p.TotalPrice * 0.80;
                //Code Block 1
                case Partner p:
                    return p.TotalPrice * 0.70;
                //Code Block 7
                case Vendor v:
                    return v.TotalPrice * 0.90;
                //Code Block 3
                case null:
                    throw new ArgumentNullException(nameof(vendor));
            }
        }
    }
    
    public class Vendor
    {
        public double TotalPrice { get; set; }
    }

    public class Partner : Vendor { }
}
