using System;

namespace Lista
{
    public interface IList<T>
    {
        bool Get(int indice, out T Obj);
        bool Set(int indice, T Obj2);
        void Push(T Objeto);
        int Length {get; set;}
    }
}