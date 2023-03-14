using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaVida
{
    internal class Tablero
    {
        Celula[,] tablero;

        public Tablero(Celula[,] tablero)
        {

            this.tablero = tablero;
        }


        public Celula[,] getTablero()
        {
            return tablero;
        }

        public void setTablero(Celula[,] tablero)
        {
            this.tablero = tablero;
        }
    }
}
