using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace JuegoDeLaVida
{
    internal class Gestor
    {
        public Gestor()
        {
        }
        public Tablero GetTableroActualizado(Tablero tablero1)
        {
            Tablero tablero2 = new Tablero(tablero1.NumFilas, tablero1.NumColumnas);
            for (int fila = 0; fila < tablero1.NumFilas; fila++)
            {
                for (int columna = 0; columna < tablero1.NumColumnas; columna++)
                {
                    int contadorCelulasVivas = GetNumeroCelulasVivas(tablero1, fila, columna);
                    if (!tablero1.TableroCelulas[fila, columna].TieneVida)
                    {                        
                        GetEstadoCelulaMuerta(contadorCelulasVivas, tablero2, fila, columna);
                    }
                    else
                    {                        
                        GetEstadoCelulaViva(contadorCelulasVivas, tablero2, fila, columna);
                    }
                }
            }
            return tablero2;
        }
        private static int GetNumeroCelulasVivas(Tablero tablero1, int fila, int columna)
        {   
            if (fila == 0 && columna == 0)
            {
                return GetCelulasVivasEsquinaSuperiorIzquierda(tablero1, fila, columna);
            }
            else if (fila == 0 && columna == tablero1.NumColumnas - 1)
            {
                return GetCelulasVivasEsquinaSuperiorDerecha(tablero1, fila, columna);
            }
            else if (fila == tablero1.NumFilas - 1 && columna == 0)
            {
                return GetCelulasVivasEsquinaInferiorIzquierda(tablero1, fila, columna);
            }
            else if (fila == tablero1.NumFilas - 1 && columna == tablero1.NumColumnas - 1)
            {
                return GetCelulasVivasEsquinaInferiorDerecha(tablero1, fila, columna);
            }
            else if (fila == 0)
            {
                return GetCelulasVivasPrimeraFila(tablero1, fila, columna);
            }
            else if (columna == 0)
            {
                return GetCelulasVivasPrimeraColumna(tablero1, fila, columna);
            }
            else if (columna == tablero1.NumColumnas - 1)
            {
                return GetCelulasVivasUltimaColumna(tablero1, fila, columna);
            }
            else if (fila == tablero1.NumFilas - 1)
            {
                return GetCelulasVivasUltimaFila(tablero1, fila, columna);
            }
            else
            {
                return GetCelulasVivasSectorInterior(tablero1, fila, columna);
            }
            return 0;
        }
        private static int GetCelulasVivasSectorInterior(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila - 1; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasUltimaFila(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila - 1; filaVecina < fila + 1; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasUltimaColumna(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila - 1; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasPrimeraColumna(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila - 1; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasPrimeraFila(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaInferiorDerecha(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila - 1; filaVecina < fila + 1; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaInferiorIzquierda(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila - 1; filaVecina < fila + 1; filaVecina++)
            {
                for (int columnaVecina = columna; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaSuperiorDerecha(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna - 1; columnaVecina < columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaSuperiorIzquierda(Tablero tablero1, int fila, int columna)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = fila; filaVecina < fila + 2; filaVecina++)
            {
                for (int columnaVecina = columna; columnaVecina < columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, fila, columna);
                }
            }
            return contadorCelulasVivas;
        }
        private void GetEstadoCelulaMuerta(int contadorCelulasVivas, Tablero tablero2, int fila, int columna)
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
        private static void GetEstadoCelulaViva(int contadorCelulasVivas, Tablero tablero2, int fila, int columna)
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
            if (tablero1.TableroCelulas[filaVecina, columnaVecina].TieneVida && tablero1.TableroCelulas[filaVecina, columnaVecina] != tablero1.TableroCelulas[fila, columna])
            {
                contadorCelulasVivas++;
            }
            return contadorCelulasVivas;
        }
    }
}
