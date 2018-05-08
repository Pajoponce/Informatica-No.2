using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOTITO
{
    public enum Ficha { _, X, O }

    public class Logica
    {
        public Ficha[,] Tablero { get; }

        private Ficha turno;

        public bool ColocarFicha(int columna)
        {
            int fila = 0;

            Tablero[columna, fila] = turno;
            //CambiarTurno();
            return false;
        }

        public string AsString(Ficha ficha)
        {
            return ficha == Ficha._ ? "" : ficha == Ficha.X ? "X" : "O";
        }

        public string GetString(int i, int j)
        {
            Ficha ficha = Tablero[i, j];
            return AsString(ficha);
        }
    }
}
