using System;

namespace JuegoDeLaVida
{
    internal class Program
    {  
       static void Main(string[] args)
        {
            char[,] celula = new char[5, 5] { 
                { ' ', '*', ' ', '*' ,'*'},
                { ' ', '*', ' ', '*', '*' },
                { ' ', '*', ' ', '*', '*' }, 
                { ' ', '*', ' ', '*', '*' }, 
                { ' ', '*', ' ', '*', '*' } };
            int contador1;
            printarArray(celula);
            for(int ite = 0; ite < 5; ite++) { 
            char[,] celula2 = new char[5,5];
            for (int i=0; i<5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    contador1 = 0;
                    if (celula[i,j].Equals(' '))
                    {
                        if (i == 0 && j == 0)
                        {
                            for (int k = i; k < i + 2; k++)
                            {
                                for (int l = j; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 0 && j == 4)
                        {
                            for (int k = i; k < i + 2; k++)
                            {
                                for (int l = j - 1; l < j + 1; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 4 && j == 0)
                        {
                            for(int k = i - 1; k < i + 1; k++)
                            {
                                for(int l = j; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 4 && j == 4)
                        {
                            for (int k = i - 1; k < i + 1; k++)
                            {
                                for (int l = j-1; l < j + 1; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 0)
                        {
                            for (int k = i; k < i + 2; k++)
                            {
                                for (int l = j - 1; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (j == 0)
                        {
                            for (int k = i-1; k < i + 2; k++)
                            {
                                for (int l = j ; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (j == 4)
                        {
                            for (int k = i - 1; k < i + 2; k++)
                            {
                                for (int l = j-1; l < j + 1; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 4)
                        {
                            for (int k = i - 1; k < i + 1; k++)
                            {
                                for (int l = j-1; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int k = i - 1; k < i + 2; k++)
                            {
                                for (int l = j - 1; l < j + 2; l++)
                                {

                                     if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }

                                }
                            }
                        }
                        if (contador1 == 3)
                        {
                            celula2[i, j]+='*';
                        }
                        else
                        {
                            celula2[i, j]+=' ';
                        }
                    }
                    else
                    {
                        if (i == 0 && j == 0)
                        {
                            for (int k = i; k < i + 2; k++)
                            {
                                for (int l = j; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 0 && j == 4)
                        {
                            for (int k = i; k < i + 2; k++)
                            {
                                for (int l = j - 1; l < j + 1; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 4 && j == 0)
                        {
                            for (int k = i - 1; k < i + 1; k++)
                            {
                                for (int l = j; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 4 && j == 4)
                        {
                            for (int k = i - 1; k < i + 1; k++)
                            {
                                for (int l = j - 1; l < j + 1; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 0)
                        {
                            for (int k = i; k < i + 2; k++)
                            {
                                for (int l = j - 1; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (j == 0 )
                        {
                            for (int k = i - 1; k < i + 2; k++)
                            {
                                for (int l = j; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (j == 4)
                        {
                            for (int k = i - 1; k < i + 2; k++)
                            {
                                for (int l = j - 1; l < j + 1; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else if (i == 4)
                        {
                            for (int k = i - 1; k < i + 1; k++)
                            {
                                for (int l = j - 1; l < j + 2; l++)
                                {
                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }
                                }
                            }
                        }
                        else 
                        {
                            for (int k = i - 1; k < i + 2; k++)
                            {
                                for (int l = j - 1; l < j + 2; l++)
                                {

                                    if (celula[k, l].Equals('*'))
                                    {
                                        contador1++;
                                    }

                                }
                            }
                        }
                        if (contador1 < 3)
                        {
                            celula2[i, j] += ' ';
                        }
                        else if (contador1 > 4)
                        {
                            celula2[i, j] += ' ';
                        }
                        else
                        {
                            celula2[i, j] += '*';
                        }

                    }
                }
            }
            Console.WriteLine();

            printarArray(celula2);
                celula = celula2;
                
            }
        }
        public static void printarArray(char[,] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[" + arr[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }

    }

