using System;
namespace Lista
{
    public class ArrayList<T> : Lista<T>
    {
        private T[] Almacenamiento{get; set;}
        public override bool Get(int indice, out T Obj)
        {
            Obj = Almacenamiento[indice];
            if (indice >= Almacenamiento.Length)
            {
                return false;
            }
            else
            {
                Obj = Almacenamiento[indice];
                return true;
            }
        }
        public override bool Set(int indice, T Obj2)
        {
            if (indice >= Almacenamiento.Length)
            {
                return false;
            }
            else
            {
                Almacenamiento[indice] = Obj2;
                return true;
            }
        }
        public override int Length{get; set;}
        public override void Push(T elemento)
        {
            T[] arr = new T[Almacenamiento.Length + 1];
            for (int i = 0; i < Almacenamiento.Length; i++)
            {
                arr[i] = Almacenamiento[i];
            }
            arr[arr.Length - 1] = elemento;
            Almacenamiento = arr;            
        }
    }
}