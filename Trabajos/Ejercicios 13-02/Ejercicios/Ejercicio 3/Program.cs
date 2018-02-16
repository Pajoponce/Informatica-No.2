using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            String Palabra_OG = Console.ReadLine();
            String Palabra__ = "";
            String[] L; L = new string[Palabra_OG.Length];
            String Final_Word = "";

            for (int i = 0; i <= Palabra_OG.Length-1; i++)
            {
                if(Palabra_OG.Substring(i,1)!=" ")
                {
                    L[i] = Palabra_OG.Substring(i, 1);
                    Palabra__ = Palabra__ + L[i];             }
            }
            for (int i = Palabra__.Length - 1; i >= 0; i--)
            {
                L[i] = Palabra__.Substring(i, 1);
                Final_Word = Final_Word + L[i];
            }
            if(Palabra__.Equals(Final_Word))
            {
                Console.WriteLine("Si es un palíndromo");
            }else
            {
                Console.WriteLine("No es un Palíndromo");
            }
            Console.Read();
        }
    }
}
