using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ137
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> list = new List<Class1>() {
                new Class1() { ID = 5, Name = "User1"},
                new Class1() { ID = 6, Name = "User2"},
                new Class1() { ID = 3, Name = "User3"},
                new Class1() { ID = 4, Name = "User4"},
            };
            Console.WriteLine(list.Count);      // LINE 07
            list.Sort();
            Console.WriteLine(list[0].Name);	// LINE 09
        }
    }

    public class Class1 : IComparable<Class1>
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public int CompareTo(Class1 other)
        {
            if (ID == other.ID) return 0;
            else return ID.CompareTo(other.ID);
        }
    }
}
