using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaVida
{
    internal class Gestor
    {
        int numfilas_;
        int numcol_;
        int numiteraciones_;
        public Gestor(int numfilas,int numcol,int numiteraciones) { 
            numfilas_= numfilas;
            numcol_ = numcol;
            numiteraciones_ = numiteraciones;
        }
        public Tablero getTableroActualizado(int numfilas, int numcol, Tablero tablero1, Tablero tablero2)
        {
            for (int fila = 0; fila < numfilas; fila++)
            {
                for (int columna = 0; columna < numcol; columna++)
                {
                    int contadorCelulasVivas = 0;
                    if (!tablero1.TableroCelulas[fila, columna].TieneVida)
                    {
                        contadorCelulasVivas = GetNumeroCelulasVivas(tablero1, fila, columna, numfilas - 1, numcol - 1);
                        getEstadoCelulaMuerta(contadorCelulasVivas, tablero2, fila, columna);
                    }
                    else
                    {
                        contadorCelulasVivas = GetNumeroCelulasVivas(tablero1, fila, columna, numfilas - 1, numcol - 1);
                        getEstadoCelulaViva(contadorCelulasVivas, tablero2, fila, columna);
                    }
                }
            }
            tablero1 = tablero2;
            return tablero1;
        }
        
        private static int GetNumeroCelulasVivas(Tablero tablero1, int fila, int columna, int maxcolumna, int maxfila)
        {
            int contadorCelulasVivas = 0;
            if (fila == 0 && columna == 0)
            {
                contadorCelulasVivas = GetCelulasVivasEsquinaSuperiorIzquierda(tablero1, fila, columna, contadorCelulasVivas);
            }
            else if (fila == 0 && columna == maxcolumna)
            {
                contadorCelulasVivas = GetCelulasVivasEsquinaSuperiorDerecha(tablero1, fila, columna, contadorCelulasVivas);
            }
            else if (fila == maxfila && columna == 0)
            {
                contadorCelulasVivas = GetCelulasVivasEsquinaInferiorIzquierda(tablero1, fila, columna, contadorCelulasVivas);
            }
            else if (fila == maxfila && columna == maxcolumna)
            {
                contadorCelulasVivas = GetCelulasVivasEsquinaInferiorDerecha(tablero1, fila, columna, contadorCelulasVivas);
            }
            else if (fila == 0)
            {
                contadorCelulasVivas = GetCelulasVivasPrimeraFila(tablero1, fila, columna, contadorCelulasVivas);
            }
            else if (columna == 0)
            {
                contadorCelulasVivas = GetCelulasVivasPrimeraColumna(tablero1, fila, columna, contadorCelulasVivas);
            }
            else if (columna == maxcolumna)
            {
                contadorCelulasVivas = GetCelulasVivasUltimaColumna(tablero1, fila, columna, contadorCelulasVivas);
            }
            else if (fila == maxfila)
            {
                contadorCelulasVivas = GetCelulasVivasUltimaFila(tablero1, fila, columna, contadorCelulasVivas);
            }
            else
            {
                contadorCelulasVivas = GetCelulasVivasSectorInterior(tablero1, fila, columna, contadorCelulasVivas);
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasSectorInterior(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila - 1; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasUltimaFila(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila - 1; filaVecina < fila + 1; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasUltimaColumna(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila - 1; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasPrimeraColumna(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila - 1; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasPrimeraFila(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaInferiorDerecha(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila - 1; filaVecina < fila + 1; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaInferiorIzquierda(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila - 1; filaVecina < fila + 1; filaVecina++)
            {
                for (int columnaVecina = columna; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaSuperiorDerecha(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaSuperiorIzquierda(Tablero tablero1, int fila, int columna, int contadorCelulasVivas)
        {
            for (int filaVecina = fila; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna; columnaVecina < columna + 2; columnaVecina++)
                {
                        contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina,fila,columna);
                }
            }
            return contadorCelulasVivas;
        }
        private void getEstadoCelulaMuerta(int contadorCelulasVivas, Tablero tablero2, int fila, int columna)
        {
            if (contadorCelulasVivas == 3)
            {
                tablero2.TableroCelulas[fila, columna].TieneVida = true;
            }
            else
            {
                tablero2.TableroCelulas[fila, columna].TieneVida = false;
            }
        }
        private static void getEstadoCelulaViva(int contadorCelulasVivas, Tablero tablero2, int fila, int columna)
        {
            if (contadorCelulasVivas < 2)
            {
                tablero2.TableroCelulas[fila, columna].TieneVida = false;
            }
            else if (contadorCelulasVivas > 3)
            {
                tablero2.TableroCelulas[fila, columna].TieneVida = false;
            }
            else
            {
                tablero2.TableroCelulas[fila, columna].TieneVida = true;
            }
        }
        private static int GetContadorCelulasVivas(Tablero tablero1, int contadorCelulasVivas, int filaVecina, int columnaVecina, int fila, int columna)
        {
            if (tablero1.TableroCelulas[filaVecina, columnaVecina].TieneVida && tablero1.TableroCelulas[filaVecina, columnaVecina]!= tablero1.TableroCelulas[fila, columna])
            {
                contadorCelulasVivas++;
            }
            return contadorCelulasVivas;
        }
    }
}
