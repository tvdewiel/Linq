using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voorbeelden
{
    public class SetOperators
    {
        IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
        IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

        public void intersect()
        {
            var result = strList1.Intersect(strList2);
            Console.WriteLine("intersect-------");
            foreach (string str in result)
                Console.WriteLine(str);
        }
        public void union()
        {
            var result = strList1.Union(strList2);
            Console.WriteLine("union-----------");
            foreach (string str in result)
                Console.WriteLine(str);
        }
        public void except()
        {
            var result = strList1.Except(strList2);
            Console.WriteLine("except-----------");
            foreach (string str in result)
                Console.WriteLine(str);
        }
    }
}
