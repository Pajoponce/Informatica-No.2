using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOTITO
{
    public partial class Form1 : Form
    {
        string[,] totito = new string[4, 4];
        string tiros = "X";
        int contador=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button botonele = (Button)sender;
            
            switch (botonele.Name)
            {

                case "button1":
                    
                    if (Validate(0, 0))
                    {
                        button1.Text = tiros;
                        YES(0, 0);
                    }
                    contador = contador + 1;
                    break;
                case "button2":
                    if (Validate(0, 1))
                    {
                        button2.Text = tiros;
                        YES(0, 1);
                    }
                    contador = contador + 1;
                    break;
                case "button3":
                    if (Validate(0, 2))
                    {
                        button3.Text = tiros;
                        YES(0, 2);
                    }
                    contador = contador + 1;
                    break;
                case "button4":
                    if (Validate(0, 3))
                    {
                        button4.Text = tiros;
                        YES(0, 3);
                    }
                    contador = contador + 1;
                    break;
                case "button5":
                    if (Validate(1, 0))
                    {
                        button5.Text = tiros;
                        YES(1, 0);
                    }
                    contador = contador + 1;
                    break;
                case "button6":
                    if (Validate(1, 1))
                    {
                        button6.Text = tiros;
                        YES(1, 1);
                    }
                    contador = contador + 1;
                    break;
                case "button7":
                    if (Validate(1, 2))
                    {
                        button7.Text = tiros;
                        YES(1, 2);
                    }
                    contador = contador + 1;
                    break;
                case "button8":
                    if (Validate(1, 3))
                    {
                        button8.Text = tiros;
                        YES(1, 3);
                    }
                    contador = contador + 1;
                    break;
                case "button9":
                    if (Validate(2, 0))
                    {
                        button9.Text = tiros;
                        YES(2, 0);
                    }
                    contador = contador + 1;
                    break;
                case "button10":
                    if (Validate(2, 1))
                    {
                        button10.Text = tiros;
                        YES(2, 1);
                    }
                    contador = contador + 1;
                    break;
                case "button11":
                    if (Validate(2, 2))
                    {
                        button11.Text = tiros;
                        YES(2, 2);
                    }
                    contador = contador + 1;
                    break;
                case "button12":
                    if (Validate(2, 3))
                    {
                        button12.Text = tiros;
                        YES(2, 3);
                    }
                    contador = contador + 1;
                    break;
                case "button13":
                    if (Validate(3, 0))
                    {
                        button13.Text = tiros;
                        YES(3, 0);
                    }
                    contador = contador + 1;
                    break;
                case "button14":
                    if (Validate(3, 1))
                    {
                        button14.Text = tiros;
                        YES(3, 1);
                    }
                    contador = contador + 1;
                    break;
                case "button15":
                    if (Validate(3, 2))
                    {
                        button15.Text = tiros;
                        YES(3, 2);
                    }
                    contador = contador + 1;
                    break;
                case "button16":
                    if (Validate(3, 3))
                    {
                        button16.Text = tiros;
                        YES(3, 3);
                    }
                    contador = contador + 1;
                    break;
            }
            if(VerficaGanador())
            {
                for (int i = 0; i <= 3; i++)
                {
                    totito[i, 0] = null;
                    totito[i, 1] = null;
                    totito[i, 2] = null;
                    totito[i, 3] = null;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button10.Text = "";
                    button11.Text = "";
                    button12.Text = "";
                    button13.Text = "";
                    button14.Text = "";
                    button15.Text = "";
                    button16.Text = "";
                    contador = 0;
                    tiros = "X";
                }
            }
            
        }
        private bool VerficaGanador()
        {
            string cc = "";
            for (int i = 0; i < 4; i++)
            {
                cc = totito[i, 0] + totito[i, 1] + totito[i, 2] + totito[i, 3];
                if (Veri(cc))
                {
                    return true;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                cc = totito[0, i] + totito[1, i] + totito[2, i] + totito[3, i];
                if (Veri(cc))
                {
                    return true;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                cc = totito[0, 0] + totito[1, 1] +totito[2, 2] + totito[3, 3];
                if (Veri(cc))
                {
                    return true;

                }

            }
            for (int i = 0; i < 4; i++)
            {
                cc = totito[0, 3] + totito[1, 2] + totito[2, 1] + totito[3,0];
                if (Veri(cc))
                {
                    return true;
                }
            }
            if (contador == 16)
            {
                MessageBox.Show("Empate");
                return true;
            }
            return false;
        }
        private static bool Veri(string cc)
        {
            if (cc == "XXXX")
            {
                MessageBox.Show("Ganador = X");
                return true;
            }
            else if (cc == "OOOO")
            {
                MessageBox.Show("Ganador = O");
                return true;
            }
            return false;
        }
        private void YES(int YA, int S)
        {
            totito[YA, S] = tiros;
            GeezRick();
        }
        private bool Validate(int fila, int columna)
        {
            if (totito[fila, columna] == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Eliga Otra Casilla");
                contador = contador - 1;
                return false;
            }
        }
        private void GeezRick()
        {
            if (tiros == "X")
            {
                tiros = "O";
            }
            else
            {
                tiros = "X";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

       
    }
}