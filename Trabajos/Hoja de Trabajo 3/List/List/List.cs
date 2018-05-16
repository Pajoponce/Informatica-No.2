using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public abstract class Lista<T> : IList<T>
    {
        public abstract bool Get(int Obj, out T Obj2);
        public abstract bool Set(int Obj, T Obj2);
        public abstract int Length{ get; }
        public abstract void Push(T elemento);


    }

}
