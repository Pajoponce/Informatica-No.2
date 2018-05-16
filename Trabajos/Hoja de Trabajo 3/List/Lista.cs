using System;

namespace Lista
{
    public abstract class Lista<T> : IList<T> 
    {
        public abstract bool Get(int indice, out T Obj);
        public abstract bool Set(int indice, T Obj2);
        public abstract void Push(T Objeto);
        public void Push(IList<T> Objeto)
        {

        }
        public abstract int Length {get; set;}
    }
}