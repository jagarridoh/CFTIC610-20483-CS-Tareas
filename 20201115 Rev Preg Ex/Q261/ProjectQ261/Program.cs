using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ261
{
    class Program
    {
        static void Main(string[] args)
        {
            string settings = "value1;value2";
            foreach (string val in settings.Split(';'))
            {
                Console.WriteLine(val);
            }
        }
    }
}
