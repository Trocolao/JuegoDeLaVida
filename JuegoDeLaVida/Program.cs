using System;

namespace JuegoDeLaVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numfilas=5;
            int numcol=5;
            int numiteraciones = 10;
            Tablero tablero1 = new Tablero(numfilas, numcol);
            Gestor gestor= new Gestor();
            gestor.RellenarTablero(tablero1);
            gestor.printarArray(tablero1);
            for (int ite = 0; ite < numiteraciones; ite++)
            {
                Tablero tablero2 = new Tablero(numfilas, numcol);
                tablero1 = gestor.getTableroActualizado(numfilas, numcol, tablero1, tablero2);
            }
        }
    }
}

