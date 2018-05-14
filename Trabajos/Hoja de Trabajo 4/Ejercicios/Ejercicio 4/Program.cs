using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = {1,2,3,4,5,6,7};
            Console.WriteLine("Ingresar número para verificar que se encuentra en el array");
            int Numero = int.Parse(Console.ReadLine());
            bool ver=false;
            for(int i=0; i<Numeros.Length; i++)
            {
                if (Numeros[i] == Numero)
                {Console.WriteLine("Si se encuentra en el array");
                    ver = true;
                }
            }
            if(ver == false)
            {
                Console.WriteLine("No se encuentra en el array");
            }
            Console.ReadLine();
        }
    }
}
