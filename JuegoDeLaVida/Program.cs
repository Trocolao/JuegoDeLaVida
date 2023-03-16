using System;

namespace JuegoDeLaVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numiteraciones=10;
            Gestor gestor = new Gestor();
            int numerofilas=5;
            int numerocolumnas = 5;
            Tablero tablero1 = new Tablero(numerofilas, numerocolumnas);
            RellenarTablero(tablero1);           
            for (int ite = 0; ite < numiteraciones; ite++)
            {
                printarArray(tablero1);
                tablero1 = gestor.getTableroActualizado(tablero1.NumFilas, tablero1.NumColumnas, tablero1, new Tablero(tablero1.NumFilas, tablero1.NumColumnas));
                Console.WriteLine();
            }
        }
        public static void printarArray(Tablero tablero)
        {
            for (int fila = 0; fila < tablero.NumFilas; fila++)
            {
                for (int columna = 0; columna < tablero.NumColumnas; columna++)
                {
                    if (tablero.TableroCelulas[fila, columna].TieneVida)
                    {
                        Console.Write("[" + "*" + "]");
                    }
                    else
                    {
                        Console.Write("[" + " " + "]");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void RellenarTablero(Tablero tablero1)
        {
            tablero1.TableroCelulas[0, 1].TieneVida = true;
            tablero1.TableroCelulas[0, 3].TieneVida = true;
            tablero1.TableroCelulas[0, 4].TieneVida = true;
            tablero1.TableroCelulas[1, 1].TieneVida = true;
            tablero1.TableroCelulas[1, 3].TieneVida = true;
            tablero1.TableroCelulas[1, 4].TieneVida = true;
            tablero1.TableroCelulas[2, 1].TieneVida = true;
            tablero1.TableroCelulas[2, 3].TieneVida = true;
            tablero1.TableroCelulas[2, 4].TieneVida = true;
            tablero1.TableroCelulas[3, 1].TieneVida = true;
            tablero1.TableroCelulas[3, 3].TieneVida = true;
            tablero1.TableroCelulas[3, 4].TieneVida = true;
            tablero1.TableroCelulas[4, 1].TieneVida = true;
            tablero1.TableroCelulas[4, 3].TieneVida = true;
            tablero1.TableroCelulas[4, 4].TieneVida = true;
        }
    }
}

