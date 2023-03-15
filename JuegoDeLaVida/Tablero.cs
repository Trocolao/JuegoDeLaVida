using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaVida
{
    internal class Tablero
    {
        Celula[,] _tablero;
        int _filas;
        int _columnas;
        static Celula viva = new Celula(true);
        static Celula muerta = new Celula(false);
        public Tablero(int filas,int columnas)
        {
            _tablero = new Celula[filas,columnas]; 
        }
        public Celula[,] TableroCelulas { 
            get {
                return _tablero;
           }
        }
    }
}
