using JuegoDeLaVida.LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeLaVida.WindowsForms
{
    public partial class Form1 : Form
    {
        Tablero tablero1 = new Tablero(5, 5);
        Gestor gestor1 = new Gestor();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (textBox00.Text == "*")
            {
                tablero1.TableroCelulas[0, 0].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[0, 0].TieneVida = false;
            }
            if (textBox01.Text == "*")
            {
                tablero1.TableroCelulas[0, 1].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[0, 1].TieneVida = false;
            }
            if (textBox02.Text == "*")
            {
                tablero1.TableroCelulas[0, 2].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[0, 2].TieneVida = false;
            }
            if (textBox03.Text == "*")
            {
                tablero1.TableroCelulas[0, 3].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[0, 3].TieneVida = false;
            }
            if (textBox04.Text == "*")
            {
                tablero1.TableroCelulas[0, 4].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[0, 4].TieneVida = false;
            }
            if (textBox10.Text == "*")
            {
                tablero1.TableroCelulas[1, 0].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[1, 0].TieneVida = false;
            }
            if (textBox11.Text == "*")
            {
                tablero1.TableroCelulas[1, 1].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[1, 1].TieneVida = false;
            }
            if (textBox12.Text == "*")
            {
                tablero1.TableroCelulas[1, 2].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[1, 2].TieneVida = false;
            }
            if (textBox13.Text == "*")
            {
                tablero1.TableroCelulas[1, 3].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[1, 3].TieneVida = false;
            }
            if (textBox14.Text == "*")
            {
                tablero1.TableroCelulas[1, 4].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[1, 4].TieneVida = false;
            }
            if (textBox20.Text == "*")
            {
                tablero1.TableroCelulas[2, 0].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[2, 0].TieneVida = false;
            }
            if (textBox21.Text == "*")
            {
                tablero1.TableroCelulas[2, 1].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[2, 1].TieneVida = false;
            }
            if (textBox22.Text == "*")
            {
                tablero1.TableroCelulas[2, 2].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[2, 2].TieneVida = false;
            }
            if (textBox23.Text == "*")
            {
                tablero1.TableroCelulas[2, 3].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[2, 3].TieneVida = false;
            }
            if (textBox24.Text == "*")
            {
                tablero1.TableroCelulas[2, 4].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[2, 4].TieneVida = false;
            }
            if (textBox30.Text == "*")
            {
                tablero1.TableroCelulas[3, 0].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[3, 0].TieneVida = false;
            }
            if (textBox31.Text == "*")
            {
                tablero1.TableroCelulas[3, 1].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[3, 1].TieneVida = false;
            }
            if (textBox32.Text == "*")
            {
                tablero1.TableroCelulas[3, 2].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[3, 2].TieneVida = false;
            }
            if (textBox33.Text == "*")
            {
                tablero1.TableroCelulas[3, 3].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[3, 3].TieneVida = false;
            }
            if (textBox34.Text == "*")
            {
                tablero1.TableroCelulas[3, 4].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[3, 4].TieneVida = false;
            }
            if (textBox40.Text == "*")
            {
                tablero1.TableroCelulas[4, 0].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[4, 0].TieneVida = false;
            }
            if (textBox41.Text == "*")
            {
                tablero1.TableroCelulas[4, 1].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[4, 1].TieneVida = false;
            }
            if (textBox42.Text == "*")
            {
                tablero1.TableroCelulas[4, 2].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[4, 2].TieneVida = false;
            }
            if (textBox43.Text == "*")
            {
                tablero1.TableroCelulas[4, 3].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[4, 3].TieneVida = false;
            }
            if (textBox44.Text == "*")
            {
                tablero1.TableroCelulas[4, 4].TieneVida = true;
            }
            else
            {
                tablero1.TableroCelulas[4, 4].TieneVida = false;
            }
            MessageBox.Show("Se han guardado los datos correctamente");
        }

        private void NuevoTablero_Click(object sender, EventArgs e)
        {
            textBox00.Clear();
            textBox01.Clear();
            textBox02.Clear();
            textBox03.Clear();
            textBox04.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox40.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox43.Clear();
            textBox44.Clear();
            MessageBox.Show("Introduzca los datos del nuevo tablero");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablero1 = gestor1.GetTableroActualizado(tablero1);
            if (tablero1.TableroCelulas[0, 0].TieneVida)
            {
                textBox00.Text = "*";
            }
            else
            {
                textBox00.Text = " ";
            }
            if (tablero1.TableroCelulas[0, 1].TieneVida)
            {
                textBox01.Text = "*";
            }
            else
            {
                textBox01.Text = " ";
            }
            if (tablero1.TableroCelulas[0, 2].TieneVida)
            {
                textBox02.Text = "*";
            }
            else
            {
                textBox02.Text = " ";
            }
            if (tablero1.TableroCelulas[0, 3].TieneVida)
            {
                textBox03.Text = "*";
            }
            else
            {
                textBox03.Text = " ";
            }
            if (tablero1.TableroCelulas[0, 4].TieneVida)
            {
                textBox04.Text = "*";
            }
            else
            {
                textBox04.Text = " ";
            }
            if (tablero1.TableroCelulas[1, 0].TieneVida)
            {
                textBox10.Text = "*";
            }
            else
            {
                textBox10.Text = " ";
            }
            if (tablero1.TableroCelulas[1, 1].TieneVida)
            {
                textBox11.Text = "*";
            }
            else
            {
                textBox11.Text = " ";
            }
            if (tablero1.TableroCelulas[1, 2].TieneVida)
            {
                textBox12.Text = "*";
            }
            else
            {
                textBox12.Text = " ";
            }
            if (tablero1.TableroCelulas[1, 3].TieneVida)
            {
                textBox13.Text = "*";
            }
            else
            {
                textBox13.Text = " ";
            }
            if (tablero1.TableroCelulas[1, 4].TieneVida)
            {
                textBox14.Text = "*";
            }
            else
            {
                textBox14.Text = " ";
            }
            if (tablero1.TableroCelulas[2, 0].TieneVida)
            {
                textBox20.Text = "*";
            }
            else
            {
                textBox20.Text = " ";
            }
            if (tablero1.TableroCelulas[2, 1].TieneVida)
            {
                textBox21.Text = "*";
            }
            else
            {
                textBox21.Text = " ";
            }
            if (tablero1.TableroCelulas[2, 2].TieneVida)
            {
                textBox22.Text = "*";
            }
            else
            {
                textBox22.Text = " ";
            }
            if (tablero1.TableroCelulas[2, 3].TieneVida)
            {
                textBox23.Text = "*";
            }
            else
            {
                textBox23.Text = " ";
            }
            if (tablero1.TableroCelulas[2, 4].TieneVida)
            {
                textBox24.Text = "*";
            }
            else
            {
                textBox24.Text = " ";
            }
            if (tablero1.TableroCelulas[3, 0].TieneVida)
            {
                textBox30.Text = "*";
            }
            else
            {
                textBox30.Text = " ";
            }
            if (tablero1.TableroCelulas[3, 1].TieneVida)
            {
                textBox31.Text = "*";
            }
            else
            {
                textBox31.Text = " ";
            }
            if (tablero1.TableroCelulas[3, 2].TieneVida)
            {
                textBox32.Text = "*";
            }
            else
            {
                textBox32.Text = " ";
            }
            if (tablero1.TableroCelulas[3, 3].TieneVida)
            {
                textBox33.Text = "*";
            }
            else
            {
                textBox33.Text = " ";
            }
            if (tablero1.TableroCelulas[3, 4].TieneVida)
            {
                textBox34.Text = "*";
            }
            else
            {
                textBox34.Text = " ";
            }
            if (tablero1.TableroCelulas[4, 0].TieneVida)
            {
                textBox40.Text = "*";
            }
            else
            {
                textBox40.Text = " ";
            }
            if (tablero1.TableroCelulas[4, 1].TieneVida)
            {
                textBox41.Text = "*";
            }
            else
            {
                textBox41.Text = " ";
            }
            if (tablero1.TableroCelulas[4, 2].TieneVida)
            {
                textBox42.Text = "*";
            }
            else
            {
                textBox42.Text = " ";
            }
            if (tablero1.TableroCelulas[4, 3].TieneVida)
            {
                textBox43.Text = "*";
            }
            else
            {
                textBox43.Text = " ";
            }
            if (tablero1.TableroCelulas[4, 4].TieneVida)
            {
                textBox44.Text = "*";
            }
            else
            {
                textBox44.Text = " ";
            }
        }
    }
}
