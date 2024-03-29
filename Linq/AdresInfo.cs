﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Linq;

namespace Linq
{
    public class AdresInfo
    {
        private string source;
        private List<data> adressen;

        public AdresInfo(string source)
        {
            this.source = source;
            adressen = new List<data>();
        }
        public void readData()
        {
            using(StreamReader sr=new StreamReader(source))
            {
                string line;
                while((line=sr.ReadLine())!=null)
                {
                    string[] x = line.Trim().Split(',');
                    adressen.Add(new data(x[0], x[1], x[2]));
                }
            }
        }
        public List<string> getProvincies()
        {
            //return adressen.Select(x => x.provincie).Distinct().OrderBy(x=>x).ToList();
            //return adressen.Select(x => x.provincie).Distinct().OrderBy(x => x.Length).ThenByDescending(x=>x).ToList();
            return adressen.Select(x => x.provincie).Distinct().OrderByDescending(x => x).ToList();
        }
        public List<string> getStraatnamen(string gemeente)
        {
            return adressen.Where(x => x.gemeente == gemeente).Select(x => x.straatnaam).ToList();
        }
        public List<data> maxStraatnaam()
        {
            var r=adressen.GroupBy(x=>x.straatnaam).OrderByDescending(x=>x.Count()).First()
                .OrderBy(x=>x.provincie).ThenBy(x=>x.gemeente).ToList();
            return r;
        }
        public List<data> maxStraatnaam(int nr)
        {
            var r = adressen.GroupBy(x => x.straatnaam).OrderByDescending(x => x.Count())
                .Take(nr).SelectMany(x=>x.ToList())
                .OrderBy(x => x.straatnaam).ThenBy(x=>x.provincie).ThenBy(x => x.gemeente).ToList();
            return r;
        }
        public List<string> commonStreetnames(string gemeente1,string gemeente2)
        {
            return getStraatnamen(gemeente1).Intersect(getStraatnamen(gemeente2)).ToList();
        }
        public List<string> onlyInX(string x,List<string> nietInY)
        {
            var s = getStraatnamen(x);
            foreach(string g in nietInY)
            {
                s = s.Except(getStraatnamen(g)).ToList();
            }
            return s;
        }
        public string gemeenteMetMaxAantalStraatnamen()
        {
            var r = adressen.GroupBy(x => x.gemeente).Select(x=>new { x.Key, n = x.Count() })
                .OrderByDescending(x=>x.n).First();
            
            return r.Key;
        }
        public string langsteStraatnaam()
        {
            var r = adressen.Select(x => x.straatnaam).OrderByDescending(x => x.Length).First();
            return r;
        }
        public data langsteStraatnaamMetGemeente()
        {
            var r = adressen.OrderByDescending(x => x.straatnaam.Length).First();
            return r;
        }
        public List<data> uniekeStraatnamen()
        {
            var r = adressen.GroupBy(x => x.straatnaam).Where(g=>g.Count()==1).Select(g=>g.First());
            return r.ToList();
        }
        public List<data> uniekeStraatnamenInGemeente(string gemeente)
        {
            var r = adressen.GroupBy(x => x.straatnaam).Where(g => g.Count() == 1)
                .Select(g => g.First()).Where(d=>d.gemeente==gemeente);
            return r.ToList();
        }
    }
}
