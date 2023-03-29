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
            ConsultarDatoCelda(tablero1, textBox00, 0, 0);
            ConsultarDatoCelda(tablero1, textBox01, 0, 1);
            ConsultarDatoCelda(tablero1, textBox02, 0, 2);
            ConsultarDatoCelda(tablero1, textBox03, 0, 3);
            ConsultarDatoCelda(tablero1, textBox04, 0, 4);

            ConsultarDatoCelda(tablero1, textBox10, 1, 0);
            ConsultarDatoCelda(tablero1, textBox11, 1, 1);
            ConsultarDatoCelda(tablero1, textBox12, 1, 2);
            ConsultarDatoCelda(tablero1, textBox13, 1, 3);
            ConsultarDatoCelda(tablero1, textBox14, 1, 4);

            ConsultarDatoCelda(tablero1, textBox20, 2, 0);
            ConsultarDatoCelda(tablero1, textBox21, 2, 1);
            ConsultarDatoCelda(tablero1, textBox22, 2, 2);
            ConsultarDatoCelda(tablero1, textBox23, 2, 3);
            ConsultarDatoCelda(tablero1, textBox24, 2, 4);

            ConsultarDatoCelda(tablero1, textBox30, 3, 0);
            ConsultarDatoCelda(tablero1, textBox31, 3, 1);
            ConsultarDatoCelda(tablero1, textBox32, 3, 2);
            ConsultarDatoCelda(tablero1, textBox33, 3, 3);
            ConsultarDatoCelda(tablero1, textBox34, 3, 4);

            ConsultarDatoCelda(tablero1, textBox40, 4, 0);
            ConsultarDatoCelda(tablero1, textBox41, 4, 1);
            ConsultarDatoCelda(tablero1, textBox42, 4, 2);
            ConsultarDatoCelda(tablero1, textBox43, 4, 3);
            ConsultarDatoCelda(tablero1, textBox44, 4, 4);

            MessageBox.Show("Los datos se han introducido correctamente");
        }

        private void ConsultarDatoCelda(Tablero tablero1,TextBox texto, int fila, int columna)
        {
            if (texto.Text == "*")
            {
                tablero1.TableroCelulas[fila, columna].TieneVida = true;
            }
            else if (texto.Text == "")
            {
                tablero1.TableroCelulas[fila, columna].TieneVida = false;
            }
            else
            {
                MessageBox.Show("En la celda con fila="+fila+" y columna="+columna+" se ha introducido un dato inválido");
                texto.Clear();
            }
        }

        private void NuevoTablero_Click(object sender, EventArgs e)
        {
            contadorDeIteraciones = 0;
            ResetearCelda(textBox00);
            ResetearCelda(textBox01);
            ResetearCelda(textBox02);
            ResetearCelda(textBox03);
            ResetearCelda(textBox04);

            ResetearCelda(textBox10);
            ResetearCelda(textBox11);
            ResetearCelda(textBox12);
            ResetearCelda(textBox13);
            ResetearCelda(textBox14);

            ResetearCelda(textBox20);
            ResetearCelda(textBox21);
            ResetearCelda(textBox22);
            ResetearCelda(textBox23);
            ResetearCelda(textBox24);

            ResetearCelda(textBox30);
            ResetearCelda(textBox31);
            ResetearCelda(textBox32);
            ResetearCelda(textBox33);
            ResetearCelda(textBox34);

            ResetearCelda(textBox40);
            ResetearCelda(textBox41);
            ResetearCelda(textBox42);
            ResetearCelda(textBox43);
            ResetearCelda(textBox44);

            MessageBox.Show("Introduzca los datos del nuevo tablero");
        }

        private void ResetearCelda(TextBox texto)
        {
            texto.Clear();
            texto.Enabled = true;
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

            ActualizarCeldaTrasIteracion(tablero1, textBox00, 0, 0);
            ActualizarCeldaTrasIteracion(tablero1, textBox01, 0, 1);
            ActualizarCeldaTrasIteracion(tablero1, textBox02, 0, 2);
            ActualizarCeldaTrasIteracion(tablero1, textBox03, 0, 3);
            ActualizarCeldaTrasIteracion(tablero1, textBox04, 0, 4);

            ActualizarCeldaTrasIteracion(tablero1, textBox10, 1, 0);
            ActualizarCeldaTrasIteracion(tablero1, textBox11, 1, 1);
            ActualizarCeldaTrasIteracion(tablero1, textBox12, 1, 2);
            ActualizarCeldaTrasIteracion(tablero1, textBox13, 1, 3);
            ActualizarCeldaTrasIteracion(tablero1, textBox14, 1, 4);

            ActualizarCeldaTrasIteracion(tablero1, textBox20, 2, 0);
            ActualizarCeldaTrasIteracion(tablero1, textBox21, 2, 1);
            ActualizarCeldaTrasIteracion(tablero1, textBox22, 2, 2);
            ActualizarCeldaTrasIteracion(tablero1, textBox23, 2, 3);
            ActualizarCeldaTrasIteracion(tablero1, textBox24, 2, 4);

            ActualizarCeldaTrasIteracion(tablero1, textBox30, 3, 0);
            ActualizarCeldaTrasIteracion(tablero1, textBox31, 3, 1);
            ActualizarCeldaTrasIteracion(tablero1, textBox32, 3, 2);
            ActualizarCeldaTrasIteracion(tablero1, textBox33, 3, 3);
            ActualizarCeldaTrasIteracion(tablero1, textBox34, 3, 4);

            ActualizarCeldaTrasIteracion(tablero1, textBox40, 4, 0);
            ActualizarCeldaTrasIteracion(tablero1, textBox41, 4, 1);
            ActualizarCeldaTrasIteracion(tablero1, textBox42, 4, 2);
            ActualizarCeldaTrasIteracion(tablero1, textBox43, 4, 3);
            ActualizarCeldaTrasIteracion(tablero1, textBox44, 4, 4);

            contadorDeIteraciones++;
            MessageBox.Show("Iteracion número: " + contadorDeIteraciones + " ");
        }

        private void ActualizarCeldaTrasIteracion(Tablero tablero1,TextBox texto, int fila, int columna)
        {
            if (tablero1.TableroCelulas[fila, columna].TieneVida)
            {
                texto.Text = "*";
            }
            else
            {
                texto.Text = "";
            }
        }
    }
}
