using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList<T> : Lista<T>
    {
        T[] Almacenamiento { get; set; }
        public override void Push(T elemento)
        {
            T[] Array = new T[Almacenamiento.Length + 1];

            for (int i = 0; i < Almacenamiento.Length; i++)
            {
                Array[i] = Almacenamiento[i];
            }
            Array[Array.Length - 1] = elemento;
            Almacenamiento = Array;
        }
        public override bool Get(int Obj, out T Almacenamiento)
        {
            throw new NotImplementedException();
        }
        public override bool Set(int Obj, T Obj2)
        {
            throw new NotImplementedException();
        }
        public override int Length => throw new NotImplementedException();  

    }
    
}
