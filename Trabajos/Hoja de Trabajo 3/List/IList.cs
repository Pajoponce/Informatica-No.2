using System;

namespace Lista
{
    public interface IList<T>
    {
        bool Get(int Obj, out T Obj2);
        bool Set(int Obj, T Obj2);
        void Push(T Objeto);
        int Length {get;}
    }
}