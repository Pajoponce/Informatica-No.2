using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class Generico
    {
        public static T Head<T>(T[] Arr)
        {
            return Arr[0];
        }
        public static T Tails<T>(T[] Arr)
        {
            return Arr[0];
        }
    }
}
