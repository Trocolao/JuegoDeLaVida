using System;

namespace JuegoDeLaVida
{
    internal class Program
    {
        static Celula viva = new Celula(true);
        static Celula muerta = new Celula(false);
        static void Main(string[] args)
        {
            Celula[,] tab = new Celula[5, 5] {
                { muerta,viva,muerta,viva,viva},
                { muerta, viva, muerta, viva, viva },
                { muerta, viva, muerta, viva, viva },
                { muerta, viva, muerta, viva, viva },
                { muerta, viva, muerta, viva, viva } };
            Tablero tablero1 = new Tablero(5, 5);
            Tablero tablero2=new Tablero(5, 5);
            RellenarTablero(tab, tablero1);
            int iteracion;
            printarArray(tablero1.TableroCelulas);
            for (int ite = 0; ite < 10; ite++)
            {
                Celula[,] tab2 = new Celula[5, 5];
                RellenarTablero(tab2, tablero2);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        iteracion = 0;
                        if (tablero1.TableroCelulas[i, j] == muerta)
                        {
                            iteracion = getIteracionesCelula(tablero1, iteracion, i, j);
                            getEstadoCelulaMuerta(iteracion, tablero2, i, j);
                        }
                        else
                        {
                            iteracion = getIteracionesCelula(tablero1, iteracion, i, j);
                            getEstadoCelulaViva(iteracion, tablero2, i, j);
                        }
                    }
                }
                Console.WriteLine();
                printarArray(tablero2.TableroCelulas);
                RellenarTablero(tablero2.TableroCelulas, tablero1);
            }
        }

        private static void RellenarTablero(Celula[,] tab, Tablero tablero1)
        {
            for (int il = 0; il < 5; il++)
            {
                for (int jl = 0; jl < 5; jl++)
                {
                    tablero1.TableroCelulas[il, jl] = tab[il, jl];
                }
            }
        }
        private static int getIteracionesCelula(Tablero tablero1, int iteracion, int i, int j)
        {
            if (i == 0 && j == 0)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else if (i == 0 && j == 4)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else if (i == 4 && j == 0)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else if (i == 4 && j == 4)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else if (i == 0)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else if (j == 0)
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else if (j == 4)
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else if (i == 4)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            else
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tablero1, iteracion, k, l);
                    }
                }
            }
            return iteracion;
        }
        private static void getEstadoCelulaMuerta(int iteracion,Tablero tablero2, int i, int j)
        {
            if (iteracion == 3)
            {
                tablero2.TableroCelulas[i, j] = viva;
            }
            else
            {
                tablero2.TableroCelulas[i, j] = muerta;
            }
        }
        private static void getEstadoCelulaViva(int iteracion,Tablero tablero2, int i, int j)
        {
            if (iteracion < 3)
            {
                tablero2.TableroCelulas[i, j] = muerta;
            }
            else if (iteracion > 4)
            {
                tablero2.TableroCelulas[i, j] = muerta;
            }
            else
            {
                tablero2.TableroCelulas[i, j] = viva;
            }
        }
        private static int getIteracion(Tablero tablero1, int iteracion, int k, int l)
        {
            if (tablero1.TableroCelulas[k, l] == viva)
            {
                iteracion++;
            }

            return iteracion;
        }
        public static void printarArray(Celula[,] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] == viva) {

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
    }
}

