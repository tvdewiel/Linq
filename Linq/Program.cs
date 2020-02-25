using System;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdresInfo ai=new AdresInfo(@"C:\data\AdresInfo.txt");
            ai.readData();

            //foreach (string p in ai.getProvincies())
            //{
            //    Console.WriteLine($"Provincie : {p}");
            //}
            //foreach (string s in ai.getStraatnamen("Berlare"))
            //{
            //    Console.WriteLine($"Straatnaam : {s}");
            //}
            //foreach (data d in ai.maxStraatnaam())
            //{
            //    Console.WriteLine(d);
            //}
            //foreach (string s in ai.commonStreetnames("Gent", "Berlare"))
            //{
            //    Console.WriteLine(s);
            //}
            //foreach (data d in ai.maxStraatnaam(3))
            //{
            //    Console.WriteLine(d);
            //}
            //foreach (string s in ai.onlyInX("Berlare",new List<string> { "Zele", "Gent", "Lokeren","Brugge" })){
            //    Console.WriteLine(s);
            //}
            Console.WriteLine(ai.gemeenteMetMaxAantalStraatnamen());
            Console.WriteLine(ai.langsteStraatnaam());
            Console.WriteLine(ai.langsteStraatnaamMetGemeente());
        }
    }
}
