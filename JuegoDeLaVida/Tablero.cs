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
        public Tablero(int filas, int columnas)
        {
            _filas = filas;
            _columnas = columnas;
            _tablero = new Celula[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    _tablero[i, j] = new Celula(false);
                }
            }
        }
        public Celula[,] TableroCelulas
        {
            get
            {
                return _tablero;
            }
        }

        public int NumFilas
        {
            get
            {
                return _filas;
            }
        }
        public int NumColumnas
        {
            get
            {
                return _columnas;
            }
        }
    }
}
