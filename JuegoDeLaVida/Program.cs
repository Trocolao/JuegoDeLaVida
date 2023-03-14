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

            Tablero tablero1=new Tablero(tab);
            int iteracion;
            printarArray(tab);
            for(int ite = 0; ite < 5; ite++) { 
            Celula[,] tab2 = new Celula[5,5];
            for (int i=0; i<5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    iteracion = 0;
                    if (tab[i,j]==muerta)
                        {
                            iteracion = getIteracionesCelulaMuerta(tab, iteracion, i, j);
                            getEstadoCelulaMuerta(iteracion, tab2, i, j);
                        }
                        else
                        {
                            iteracion = getIteracionesCelulaViva(tab, iteracion, i, j);
                            getEstadoCelulaViva(iteracion, tab2, i, j);
                        }
                    }
            }
            Console.WriteLine();

            printarArray(tab2);
                tab = tab2;
                
            }
        }

        private static int getIteracionesCelulaViva(Celula[,] tab, int iteracion, int i, int j)
        {
            if (i == 0 && j == 0)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 0 && j == 4)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 4 && j == 0)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 4 && j == 4)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 0)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (j == 0)
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (j == 4)
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 4)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }

            return iteracion;
        }

        private static int getIteracionesCelulaMuerta(Celula[,] tab, int iteracion, int i, int j)
        {
            if (i == 0 && j == 0)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 0 && j == 4)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 4 && j == 0)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 4 && j == 4)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 0)
            {
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (j == 0)
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (j == 4)
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 1; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else if (i == 4)
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        iteracion = getIteracion(tab, iteracion, k, l);
                    }
                }
            }
            else
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {

                        iteracion = getIteracion(tab, iteracion, k, l);

                    }
                }
            }

            return iteracion;
        }

        private static void getEstadoCelulaMuerta(int iteracion, Celula[,] tab2, int i, int j)
        {
            if (iteracion == 3)
            {
                tab2[i, j] = viva;
            }
            else
            {
                tab2[i, j] = muerta;
            }
        }
        private static void getEstadoCelulaViva(int iteracion, Celula[,] tab2, int i, int j)
        {
            if (iteracion < 3)
            {
                tab2[i, j] = muerta;
            }
            else if (iteracion > 4)
            {
                tab2[i, j] = muerta;
            }
            else
            {
                tab2[i, j] = viva;
            }
        }
        private static int getIteracion(Celula[,] tab, int iteracion, int k, int l)
        {
            if (tab[k, l] == viva)
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

