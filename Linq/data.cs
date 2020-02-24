using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class data
    {
        public string provincie;
        public string gemeente;
        public string straatnaam;

        public data(string provincie, string gemeente, string straatnaam)
        {
            this.provincie = provincie;
            this.gemeente = gemeente;
            this.straatnaam = straatnaam;
        }
        public override string ToString()
        {
            return $"{provincie},{gemeente},{straatnaam}";
        }
    }
}
