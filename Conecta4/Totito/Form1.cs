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
        string[,] totito = new string[6, 7];
        string tiros = "X";
        int contador=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        private void Ganador()
        {
            if (VerficaGanador())
            {
                for (int i = 0; i <=5; i++)
                {
                    totito[i, 0] = null;
                    totito[i, 1] = null;
                    totito[i, 2] = null;
                    totito[i, 3] = null;
                    totito[i, 4] = null;
                    totito[i, 5] = null;
                    totito[i, 6] = null;
                }
                contador = 0;
                tiros = "X";
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
                button17.Text = "";
                button18.Text = "";
                button19.Text = "";
                button20.Text = "";
                button21.Text = "";
                button22.Text = "";
                button23.Text = "";
                button24.Text = "";
                button25.Text = "";
                button26.Text = "";
                button27.Text = "";
                button28.Text = "";
                button29.Text = "";
                button30.Text = "";
                button31.Text = "";
                button32.Text = "";
                button33.Text = "";
                button34.Text = "";
                button35.Text = "";
                button36.Text = "";
                button37.Text = "";
                button38.Text = "";
                button39.Text = "";
                button40.Text = "";
                button41.Text = "";
                button42.Text = "";
                button42.Text = "";
            }
        }
        public bool VerficaGanador()
        {
            for (int i = 5; i > -1; i--)
            {
                if (totito[i,0] != null && totito[i,1] != null && totito[i, 2] != null && totito[i, 3] != null)
                {
                    if ((totito[i, 0] + totito[i, 1]) == (totito[i, 2] + totito[i, 3]))
                    {
                        string ganador = totito[i, 0];
                        MessageBox.Show("Ganador " + ganador);
                        return true;
                    }
                }
                // Ganador de las Cordenadas empezando en 0
            }
            for (int i = 5; i > -1; i--)
            {
                if (totito[i, 6] != null && totito[i, 5] != null && totito[i, 4] != null && totito[i, 3] != null)
                {
                    if ((totito[i, 6] + totito[i, 5]) == (totito[i, 4] + totito[i, 3]))
                    {
                        string ganador = totito[i, 6];
                        MessageBox.Show("Ganador " + ganador);
                        return true;
                    }
                }
                // Ganador de las Cordenadas empezando en 3
            }
            
             for (int i = 5; i > -1; i--)
            {
                if (totito[i, 4] != null && totito[i, 2] != null && totito[i, 3] != null && totito[i, 1] != null)
                {
                    if ((totito[i, 4] + totito[i, 2]) == (totito[i, 3] + totito[i, 1]))
                    {
                        string ganador = totito[i, 1];
                        MessageBox.Show("Ganador " + ganador);
                        return true;
                       
                    }
                }
                // Ganador de las Cordenadas empezado en 1
            } 
            for (int i = 5; i > -1; i--)
            {
                if (totito[i, 5] != null && totito[i, 3] != null && totito[i, 4] != null && totito[i, 2] != null)
                {
                    if ((totito[i, 5] + totito[i, 3]) == (totito[i, 4] + totito[i, 2]))
                    {
                        string ganador = totito[i, 2];
                        MessageBox.Show("Ganador " + ganador);
                        return true;
                    }
                }
                // Ganador de las Cordenadas empezando en 2
            }

            for (int i = 0; i < 4; i++) 
            {
                if (totito[0, i] != null && totito[1, i] != null && totito[2, i] != null && totito[3, i] != null) 
                {
                    if ((totito[0, i] + totito[1, i+1]) == (totito[2, i+2] + totito[3, i+3]))
                    {
                        string ganador = totito[0, i];
                        MessageBox.Show("Ganador " + ganador);
                        return true;
                    }
                }
                // Ganador en diagonal empezando en 0,0
            }


            return false;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                contador = contador + 1;
                for (int i = 5; i > -1; i--)
                {
                    checkBox1.Checked = false;
                    if (totito[i, 0] == null) 
                    {
                        totito[i, 0] = tiros;
                        button1.Text = totito[0, 0];
                        button8.Text = totito[1, 0];
                        button15.Text = totito[2, 0];
                        button22.Text = totito[3, 0];
                        button29.Text = totito[4, 0];
                        button36.Text = totito[5, 0];
                        GeezRick();
                        Ganador();
                        break;
                    }
                }
            }
        }
       

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                contador = contador + 1;
                for (int i = 5; i > -1; i--)
                {
                    checkBox2.Checked = false;
                    if (totito[i, 1] == null)
                    {
                        totito[i, 1] = tiros;
                        button2.Text = totito[0, 1];
                        button9.Text = totito[1, 1];
                        button16.Text = totito[2, 1];
                        button23.Text = totito[3, 1];
                        button30.Text = totito[4, 1];
                        button37.Text = totito[5, 1];
                        GeezRick();
                        Ganador();
                        break;
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                contador = contador + 1;
                for (int i = 5; i > -1; i--)
                {
                    checkBox3.Checked = false;
                    if (totito[i, 2] == null)
                    {
                        totito[i, 2] = tiros;
                        button3.Text = totito[0, 2];
                        button10.Text = totito[1, 2];
                        button17.Text = totito[2, 2];
                        button24.Text = totito[3, 2];
                        button31.Text = totito[4, 2];
                        button38.Text = totito[5, 2];
                        GeezRick();
                        Ganador();
                        break;
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                contador = contador + 1;
                for (int i = 5; i > -1; i--)
                {
                    checkBox4.Checked = false;
                    if (totito[i, 3] == null)
                    {
                        totito[i, 3] = tiros;
                        button4.Text = totito[0, 3];
                        button11.Text = totito[1, 3];
                        button18.Text = totito[2, 3];
                        button25.Text = totito[3, 3];
                        button32.Text = totito[4, 3];
                        button39.Text = totito[5, 3];
                        GeezRick();
                        Ganador();
                        break;
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                contador = contador + 1;
                for (int i = 5; i > -1; i--)
                {
                    checkBox5.Checked = false;
                    if (totito[i, 4] == null)
                    {
                        totito[i, 4] = tiros;
                        button5.Text = totito[0, 4];
                        button12.Text = totito[1, 4];
                        button19.Text = totito[2, 4];
                        button26.Text = totito[3, 4];
                        button33.Text = totito[4, 4];
                        button40.Text = totito[5, 4];
                        GeezRick();
                        Ganador();
                        break;
                    }
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                contador = contador + 1;
                for (int i = 5; i > -1; i--)
                {
                    checkBox6.Checked = false;
                    if (totito[i, 5] == null)
                    {
                        totito[i, 5] = tiros;
                        button6.Text = totito[0, 5];
                        button13.Text = totito[1, 5];
                        button20.Text = totito[2, 5];
                        button27.Text = totito[3, 5];
                        button34.Text = totito[4, 5];
                        button41.Text = totito[5, 5];
                        GeezRick();
                        Ganador();
                        break;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                contador = contador + 1;
                for (int i = 5; i > -1; i--)
                {
                    checkBox7.Checked = false;
                    if (totito[i, 6] == null)
                    {
                        totito[i, 6] = tiros;
                        button7.Text = totito[0, 6];
                        button14.Text = totito[1, 6];
                        button21.Text = totito[2, 6];
                        button28.Text = totito[3, 6];
                        button35.Text = totito[4, 6];
                        button42.Text = totito[5, 6];
                        GeezRick();
                        Ganador();
                        break;
                    }
                }
            }
        }
    }
}