using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip
{
    public static class ZipMethod
    {
        public static IEnumerable<T> zip<T>(IEnumerable<T> enum1, IEnumerable<T> enum2) 
        {
            IEnumerator<T> enumr1 = enum1.GetEnumerator();
            IEnumerator<T> enumr2 = enum2.GetEnumerator();

            while(true)
            {
                bool hmn = false;
                if(enumr1.MoveNext())
                {
                    yield return enumr1.Current; 
                    hmn = true;
                }
                if(enumr2.MoveNext())
                {
                    yield return enumr2.Current; 
                    hmn = true;
                }
                if(!hmn) break;
            }
        }
    }
}
