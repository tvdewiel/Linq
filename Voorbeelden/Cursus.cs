using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeelden
{
    public class Cursus
    {
        public Cursus(string naam, int studiepunten)
        {
            this.naam = naam;
            this.studiepunten = studiepunten;
        }

        public string naam { get; set; }
        public int studiepunten { get; set; }
        public override string ToString()
        {
            return $"{naam},{studiepunten}";
        }
    }
}
