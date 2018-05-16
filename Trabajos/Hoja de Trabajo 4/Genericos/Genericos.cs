using System;
using System.Collections.Generic;

namespace Genericos
{
    public class Genericos
    {
        public static T Head<T>(T[] Arr)
        {
            return Arr[0];
        }
    }
}