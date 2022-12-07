using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class myDictionary<Tkey, Tvalue>
    {
        Tkey[] k = new Tkey[0];
        Tvalue[] v=new Tvalue[0];

        public myDictionary()
        {
            
        }

        
        public void Add(Tkey key,Tvalue value) 
        {
            Tkey[] kTemparray = k;
            k = new Tkey[k.Length + 1];
            Tvalue[] vTemparray = v;
            v = new Tvalue[v.Length + 1];

            for (int i = 0; i < kTemparray.Length; i++)
            {
                k[i] = kTemparray[i];
                v[i] = vTemparray[i];
            }
            v[v.Length - 1] = value;
            k[k.Length - 1] = key;
        }

        public int Length
        {
            get { return v.Length; }

        }
        public int Count()
        {

            return k.Length;
        }
        public void Get()
        {
            for (int i = 0; i < Count(); i++)
            {
                Console.WriteLine( "k[i]"  , v[i]);
            }
        }
    }

}

