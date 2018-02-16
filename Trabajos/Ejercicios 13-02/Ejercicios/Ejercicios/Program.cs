using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            String X = Console.ReadLine();
            String[] L; L = new string[X.Length];
            String Final_Word = "";

            for (int i = X.Length - 1; i >= 0; i--)
            {
                L[i] = X.Substring(i, 1);
                Final_Word = Final_Word + L[i];
            }
            if (X.Equals(Final_Word))
            {
                Console.WriteLine("Si es un Anagrama");
            }
            else
            {
                Console.WriteLine("No es un Anagrama");
            }
            Console.ReadLine();
        }
    }
}
