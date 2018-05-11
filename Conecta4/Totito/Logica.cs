﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOTITO
{
    //public enum Ficha { _, X, O }

    public class Logica
    {
        //public String[,] Tablero { get; }
        public String turno;
        public String turnotemp;
        public String[,] Tablero = new String[6, 7];

        public bool VerificaGanador(int columna)
        {
            //Horizontal
            if (columna < 3)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (Tablero[i, columna] + Tablero[i, columna + 1] + Tablero[i, columna + 2] + Tablero[i, columna + 3] == (turnotemp + turnotemp + turnotemp + turnotemp)) 
                    {
                        return true;
                    }
                }

            }
            if (columna > 2)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (Tablero[i, columna] + Tablero[i, columna - 1] + Tablero[i, columna - 2] + Tablero[i, columna - 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
                    {
                        return true;
                    }
                }
            }
            //Vertical
            for (int i = 5; i > 2; i--)
            {
                if (Tablero[i, columna] + Tablero[i - 1, columna] + Tablero[i - 2, columna] + Tablero[i - 3, columna] == (turnotemp + turnotemp + turnotemp + turnotemp))
                {
                    return true;
                }
            }
            //Diagonal
            //Red
            for (int i = 6; i >= 4; i--)
            {
                if (Tablero[0, i] + Tablero[1, i - 1] + Tablero[2, i - 2] + Tablero[3, i - 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
                {
                    return true;
                }
            }
            if (Tablero[1, 6] + Tablero[2, 5] + Tablero[3, 4] + Tablero[4, 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
            {
                return true;
            }
            //Green
            for (int i = 0; i <= 2; i++)
            {
                if (Tablero[i, 0] + Tablero[i + 1, 1] + Tablero[i + 2, 2] + Tablero[i + 3, 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
                {
                    return true;
                }
            }
            for (int i = 1; i <= 2; i++)
            {
                if (Tablero[0, i] + Tablero[1, i + 1] + Tablero[2, i + 2] + Tablero[3, i + 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
                {
                    return true;
                }
            }
            //Blue
            for (int i = 6; i >= 4; i--)
            {
                if (Tablero[5, i] + Tablero[4, i - 1] + Tablero[3, i - 2] + Tablero[2, i - 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
                {
                    return true;
                }
            }
            if (Tablero[4, 6] + Tablero[3, 5] + Tablero[2, 4] + Tablero[1, 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
            {
                return true;
            }
            //Yellow
            for (int i = 0; i <= 3; i++)
            {
                if (Tablero[5, i] + Tablero[4, i + 1] + Tablero[3, i + 2] + Tablero[2, i + 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
                {
                    return true;
                }
            }
            for (int i = 3; i <= 4; i++)
            {
                if (Tablero[i, 0] + Tablero[i - 1, 1] + Tablero[i - 2, 2] + Tablero[i - 3, 3] == (turnotemp + turnotemp + turnotemp + turnotemp))
                {
                    return true;
                }
            }
            return false;
        }
        public void limpiar()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 7; a++)
                {
                    Tablero[i,a] = null;
                    turno = "X";
                }
            }
            
        }
        public string CambiarTurno()
        {
            turno = (turno == "X") ? "O" :  "X";
            return turno;
        }

        public bool ColocarFicha(int columna)
        {
            for(int f= 5; f> -1; f--)
            {
                if(Tablero[f,columna] == null)
                {
                    Tablero[f, columna] = turno;
                    turnotemp = turno;
                    CambiarTurno();
                    
                    return true;
                }
            }
            return false;
        }
        public string GetString(int i, int j)
        {
            return Tablero[i, j];
        }
    }
}
