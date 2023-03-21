using JuegoDeLaVida.LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        int contadorDeIteraciones = 0;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Introduce los datos dentro del siguiente tablero, utiliza el * para las células vivas y nada para las muertas, si se introduce algún dato inválido este será sustituido por una célula muerta");
        }
        private void introducirDatos(Tablero tablero1)
        {
            if (textBox00.Text == "*")
            {
                tablero1.TableroCelulas[0, 0].TieneVida = true;
            }
            else if (textBox00.Text == "")
            {
                tablero1.TableroCelulas[0, 0].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=0 y columna=0 se ha introducido un dato inválido");
                textBox00.Clear();
            }
            if (textBox01.Text == "*")
            {
                tablero1.TableroCelulas[0, 1].TieneVida = true;
            }
            else if (textBox01.Text == "")
            {
                tablero1.TableroCelulas[0, 1].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=0 y columna=1 se ha introducido un dato inválido");
                textBox01.Clear();
            }
            if (textBox02.Text == "*")
            {
                tablero1.TableroCelulas[0, 2].TieneVida = true;
            }
            else if (textBox02.Text == "")
            {
                tablero1.TableroCelulas[0, 2].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=0 y columna=2 se ha introducido un dato inválido");
                textBox02.Clear();
            }
            if (textBox03.Text == "*")
            {
                tablero1.TableroCelulas[0, 3].TieneVida = true;
            }
            else if (textBox03.Text == "")
            {
                tablero1.TableroCelulas[0, 3].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=0 y columna=3 se ha introducido un dato inválido");
                textBox03.Clear();
            }
            if (textBox04.Text == "*")
            {
                tablero1.TableroCelulas[0, 4].TieneVida = true;
            }
            else if (textBox04.Text == "")
            {
                tablero1.TableroCelulas[0, 4].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=0 y columna=4 se ha introducido un dato inválido");
                textBox04.Clear();
            }
            if (textBox10.Text == "*")
            {
                tablero1.TableroCelulas[1, 0].TieneVida = true;
            }
            else if (textBox10.Text == "")
            {
                tablero1.TableroCelulas[1, 0].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=1 y columna=0 se ha introducido un dato inválido");
                textBox10.Clear();
            }
            if (textBox11.Text == "*")
            {
                tablero1.TableroCelulas[1, 1].TieneVida = true;
            }
            else if (textBox11.Text == "")
            {
                tablero1.TableroCelulas[1, 1].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=1 y columna=1 se ha introducido un dato inválido");
                textBox11.Clear();
            }
            if (textBox12.Text == "*")
            {
                tablero1.TableroCelulas[1, 2].TieneVida = true;
            }
            else if (textBox12.Text == "")
            {
                tablero1.TableroCelulas[1, 2].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=1 y columna=2 se ha introducido un dato inválido");
                textBox12.Clear();
            }
            if (textBox13.Text == "*")
            {
                tablero1.TableroCelulas[1, 3].TieneVida = true;
            }
            else if (textBox13.Text == "")
            {
                tablero1.TableroCelulas[1, 3].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=1 y columna=3 se ha introducido un dato inválido");
                textBox13.Clear();
            }
            if (textBox14.Text == "*")
            {
                tablero1.TableroCelulas[1, 4].TieneVida = true;
            }
            else if (textBox14.Text == "")
            {
                tablero1.TableroCelulas[1, 4].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=1 y columna=4 se ha introducido un dato inválido");
                textBox14.Clear();
            }
            if (textBox20.Text == "*")
            {
                tablero1.TableroCelulas[2, 0].TieneVida = true;
            }
            else if (textBox20.Text == "")
            {
                tablero1.TableroCelulas[2, 0].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=2 y columna=0 se ha introducido un dato inválido");
                textBox20.Clear();
            }
            if (textBox21.Text == "*")
            {
                tablero1.TableroCelulas[2, 1].TieneVida = true;
            }
            else if (textBox21.Text == "")
            {
                tablero1.TableroCelulas[2, 1].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=2 y columna=1 se ha introducido un dato inválido");
                textBox21.Clear();
            }
            if (textBox22.Text == "*")
            {
                tablero1.TableroCelulas[2, 2].TieneVida = true;
            }
            else if (textBox22.Text == "")
            {
                tablero1.TableroCelulas[2, 2].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=2 y columna=2 se ha introducido un dato inválido");
                textBox22.Clear();
            }
            if (textBox23.Text == "*")
            {
                tablero1.TableroCelulas[2, 3].TieneVida = true;
            }
            else if (textBox23.Text == "")
            {
                tablero1.TableroCelulas[2, 3].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=2 y columna=3 se ha introducido un dato inválido");
                textBox23.Clear();
            }
            if (textBox24.Text == "*")
            {
                tablero1.TableroCelulas[2, 4].TieneVida = true;
            }
            else if (textBox24.Text == "")
            {
                tablero1.TableroCelulas[2, 4].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=2 y columna=4 se ha introducido un dato inválido");
                textBox24.Clear();
            }
            if (textBox30.Text == "*")
            {
                tablero1.TableroCelulas[3, 0].TieneVida = true;
            }
            else if (textBox30.Text == "")
            {
                tablero1.TableroCelulas[3, 0].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=3 y columna=0 se ha introducido un dato inválido");
                textBox30.Clear();
            }
            if (textBox31.Text == "*")
            {
                tablero1.TableroCelulas[3, 1].TieneVida = true;
            }
            else if (textBox31.Text == "")
            {
                tablero1.TableroCelulas[3, 1].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=3 y columna=1 se ha introducido un dato inválido");
                textBox31.Clear();
            }
            if (textBox32.Text == "*")
            {
                tablero1.TableroCelulas[3, 2].TieneVida = true;
            }
            else if (textBox32.Text == "")
            {
                tablero1.TableroCelulas[3, 2].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=3 y columna=2 se ha introducido un dato inválido");
                textBox32.Clear();
            }
            if (textBox33.Text == "*")
            {
                tablero1.TableroCelulas[3, 3].TieneVida = true;
            }
            else if (textBox33.Text == "")
            {
                tablero1.TableroCelulas[3, 3].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=3 y columna=3 se ha introducido un dato inválido");
                textBox33.Clear();
            }
            if (textBox34.Text == "*")
            {
                tablero1.TableroCelulas[3, 4].TieneVida = true;
            }
            else if (textBox34.Text == "")
            {
                tablero1.TableroCelulas[3, 4].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=3 y columna=4 se ha introducido un dato inválido");
                textBox34.Clear();
            }
            if (textBox40.Text == "*")
            {
                tablero1.TableroCelulas[4, 0].TieneVida = true;
            }
            else if (textBox40.Text == "")
            {
                tablero1.TableroCelulas[4, 0].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=4 y columna=0 se ha introducido un dato inválido");
                textBox40.Clear();
            }
            if (textBox41.Text == "*")
            {
                tablero1.TableroCelulas[4, 1].TieneVida = true;
            }
            else if (textBox41.Text == "")
            {
                tablero1.TableroCelulas[4, 1].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=4 y columna=1 se ha introducido un dato inválido");
                textBox41.Clear();
            }
            if (textBox42.Text == "*")
            {
                tablero1.TableroCelulas[4, 2].TieneVida = true;
            }
            else if (textBox42.Text == "")
            {
                tablero1.TableroCelulas[4, 2].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=4 y columna=2 se ha introducido un dato inválido");
                textBox42.Clear();
            }
            if (textBox43.Text == "*")
            {
                tablero1.TableroCelulas[4, 3].TieneVida = true;
            }
            else if (textBox43.Text == "")
            {
                tablero1.TableroCelulas[4, 3].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=4 y columna=3 se ha introducido un dato inválido");
                textBox43.Clear();
            }
            if (textBox44.Text == "*")
            {
                tablero1.TableroCelulas[4, 4].TieneVida = true;
            }
            else if (textBox44.Text == "")
            {
                tablero1.TableroCelulas[4, 4].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila=4 y columna=4 se ha introducido un dato inválido");
                textBox44.Clear();
            }
            MessageBox.Show("Los datos se han introducido correctamente");
        }
        private void NuevoTablero_Click(object sender, EventArgs e)
        {
            contadorDeIteraciones=0;
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
            textBox00.Enabled = true;
            textBox01.Enabled = true;
            textBox02.Enabled = true;
            textBox03.Enabled = true;
            textBox04.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox20.Enabled = true;
            textBox21.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox30.Enabled = true;
            textBox31.Enabled = true;
            textBox32.Enabled = true;
            textBox33.Enabled = true;
            textBox34.Enabled = true;
            textBox40.Enabled = true;
            textBox41.Enabled = true;
            textBox42.Enabled = true;
            textBox43.Enabled = true;
            textBox44.Enabled = true;
            MessageBox.Show("Introduzca los datos del nuevo tablero");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (contadorDeIteraciones == 0)
            {
                introducirDatos(tablero1);
            }
            textBox00.Enabled = false;
            textBox01.Enabled = false;
            textBox02.Enabled = false;
            textBox03.Enabled = false;
            textBox04.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            tablero1 = gestor1.GetTableroActualizado(tablero1);
            if (tablero1.TableroCelulas[0, 0].TieneVida)
            {
                textBox00.Text = "*";
            }
            else
            {
                textBox00.Text = "";
            }
            if (tablero1.TableroCelulas[0, 1].TieneVida)
            {
                textBox01.Text = "*";
            }
            else
            {
                textBox01.Text = "";
            }
            if (tablero1.TableroCelulas[0, 2].TieneVida)
            {
                textBox02.Text = "*";
            }
            else
            {
                textBox02.Text = "";
            }
            if (tablero1.TableroCelulas[0, 3].TieneVida)
            {
                textBox03.Text = "*";
            }
            else
            {
                textBox03.Text = "";
            }
            if (tablero1.TableroCelulas[0, 4].TieneVida)
            {
                textBox04.Text = "*";
            }
            else
            {
                textBox04.Text = "";
            }
            if (tablero1.TableroCelulas[1, 0].TieneVida)
            {
                textBox10.Text = "*";
            }
            else
            {
                textBox10.Text = "";
            }
            if (tablero1.TableroCelulas[1, 1].TieneVida)
            {
                textBox11.Text = "*";
            }
            else
            {
                textBox11.Text = "";
            }
            if (tablero1.TableroCelulas[1, 2].TieneVida)
            {
                textBox12.Text = "*";
            }
            else
            {
                textBox12.Text = "";
            }
            if (tablero1.TableroCelulas[1, 3].TieneVida)
            {
                textBox13.Text = "*";
            }
            else
            {
                textBox13.Text = "";
            }
            if (tablero1.TableroCelulas[1, 4].TieneVida)
            {
                textBox14.Text = "*";
            }
            else
            {
                textBox14.Text = "";
            }
            if (tablero1.TableroCelulas[2, 0].TieneVida)
            {
                textBox20.Text = "*";
            }
            else
            {
                textBox20.Text = "";
            }
            if (tablero1.TableroCelulas[2, 1].TieneVida)
            {
                textBox21.Text = "*";
            }
            else
            {
                textBox21.Text = "";
            }
            if (tablero1.TableroCelulas[2, 2].TieneVida)
            {
                textBox22.Text = "*";
            }
            else
            {
                textBox22.Text = "";
            }
            if (tablero1.TableroCelulas[2, 3].TieneVida)
            {
                textBox23.Text = "*";
            }
            else
            {
                textBox23.Text = "";
            }
            if (tablero1.TableroCelulas[2, 4].TieneVida)
            {
                textBox24.Text = "*";
            }
            else
            {
                textBox24.Text = "";
            }
            if (tablero1.TableroCelulas[3, 0].TieneVida)
            {
                textBox30.Text = "*";
            }
            else
            {
                textBox30.Text = "";
            }
            if (tablero1.TableroCelulas[3, 1].TieneVida)
            {
                textBox31.Text = "*";
            }
            else
            {
                textBox31.Text = "";
            }
            if (tablero1.TableroCelulas[3, 2].TieneVida)
            {
                textBox32.Text = "*";
            }
            else
            {
                textBox32.Text = "";
            }
            if (tablero1.TableroCelulas[3, 3].TieneVida)
            {
                textBox33.Text = "*";
            }
            else
            {
                textBox33.Text = "";
            }
            if (tablero1.TableroCelulas[3, 4].TieneVida)
            {
                textBox34.Text = "*";
            }
            else
            {
                textBox34.Text = "";
            }
            if (tablero1.TableroCelulas[4, 0].TieneVida)
            {
                textBox40.Text = "*";
            }
            else
            {
                textBox40.Text = "";
            }
            if (tablero1.TableroCelulas[4, 1].TieneVida)
            {
                textBox41.Text = "*";
            }
            else
            {
                textBox41.Text = "";
            }
            if (tablero1.TableroCelulas[4, 2].TieneVida)
            {
                textBox42.Text = "*";
            }
            else
            {
                textBox42.Text = "";
            }
            if (tablero1.TableroCelulas[4, 3].TieneVida)
            {
                textBox43.Text = "*";
            }
            else
            {
                textBox43.Text = "";
            }
            if (tablero1.TableroCelulas[4, 4].TieneVida)
            {
                textBox44.Text = "*";
            }
            else
            {
                textBox44.Text = "";
            }
            contadorDeIteraciones++;
            MessageBox.Show("Iteracion número: " + contadorDeIteraciones + " ");
        }
    }
}
