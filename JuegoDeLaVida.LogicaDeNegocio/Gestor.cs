using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace JuegoDeLaVida.LogicaDeNegocio
{
    public class Gestor
    {
        public Gestor()
        {
        }
        public Tablero GetTableroActualizado(Tablero tablero1)
        {
            Posicion posicion = new Posicion();
            Tablero tablero2 = new Tablero(tablero1.NumFilas, tablero1.NumColumnas);
            for (posicion.Fila = 0; posicion.Fila < tablero1.NumFilas; posicion.Fila++)
            {
                for (posicion.Columna = 0; posicion.Columna < tablero1.NumColumnas; posicion.Columna++)
                {
                    int contadorCelulasVivas = GetNumeroCelulasVivas(tablero1, posicion);
                    if (!tablero1.TableroCelulas[posicion.Fila, posicion.Columna].TieneVida)
                    {                        
                        GetEstadoCelulaMuerta(contadorCelulasVivas, tablero2, posicion);
                    }
                    else
                    {                        
                        GetEstadoCelulaViva(contadorCelulasVivas, tablero2, posicion);
                    }
                }
            }
            return tablero2;
        }
        private static int GetNumeroCelulasVivas(Tablero tablero1, Posicion posicion)
        {   
            if (posicion.Fila == 0 && posicion.Columna == 0)
            {
                return GetCelulasVivasEsquinaSuperiorIzquierda(tablero1, posicion);
            }
            else if (posicion.Fila == 0 && posicion.Columna == tablero1.NumColumnas - 1)
            {
                return GetCelulasVivasEsquinaSuperiorDerecha(tablero1, posicion);
            }
            else if (posicion.Fila == tablero1.NumFilas - 1 &&  posicion.Columna == 0)
            {
                return GetCelulasVivasEsquinaInferiorIzquierda(tablero1, posicion);
            }
            else if (posicion.Fila == tablero1.NumFilas - 1 && posicion.Columna == tablero1.NumColumnas - 1)
            {
                return GetCelulasVivasEsquinaInferiorDerecha(tablero1, posicion);
            }
            else if (posicion.Fila == 0)
            {
                return GetCelulasVivasPrimeraFila(tablero1, posicion);
            }
            else if (posicion.Columna == 0)
            {
                return GetCelulasVivasPrimeraColumna(tablero1, posicion);
            }
            else if (posicion.Columna == tablero1.NumColumnas - 1)
            {
                return GetCelulasVivasUltimaColumna(tablero1, posicion);
            }
            else if (posicion.Fila == tablero1.NumFilas - 1)
            {
                return GetCelulasVivasUltimaFila(tablero1, posicion);
            }
            else
            {
                return GetCelulasVivasSectorInterior(tablero1, posicion);
            }
            return 0;
        }
        private static int GetCelulasVivasSectorInterior(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila - 1; filaVecina < posicion.Fila + 2; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna - 1; columnaVecina < posicion.Columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasUltimaFila(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila - 1; filaVecina < posicion.Fila + 1; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna - 1; columnaVecina < posicion.Columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasUltimaColumna(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila - 1; filaVecina < posicion.Fila + 2; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna - 1; columnaVecina < posicion.Columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasPrimeraColumna(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila - 1; filaVecina < posicion.Fila + 2; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna; columnaVecina < posicion.Columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasPrimeraFila(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila; filaVecina < posicion.Fila + 2; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna - 1; columnaVecina < posicion.Columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaInferiorDerecha(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila - 1; filaVecina < posicion.Fila + 1; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna - 1; columnaVecina < posicion.Columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaInferiorIzquierda(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila - 1; filaVecina < posicion.Fila + 1; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna; columnaVecina < posicion.Columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaSuperiorDerecha(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila; filaVecina < posicion.Fila + 2; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna - 1; columnaVecina < posicion.Columna + 1; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private static int GetCelulasVivasEsquinaSuperiorIzquierda(Tablero tablero1, Posicion posicion)
        {
            int contadorCelulasVivas = 0;
            for (int filaVecina = posicion.Fila; filaVecina < posicion.Fila + 2; filaVecina++)
            {
                for (int columnaVecina = posicion.Columna; columnaVecina < posicion.Columna + 2; columnaVecina++)
                {
                    contadorCelulasVivas = GetContadorCelulasVivas(tablero1, contadorCelulasVivas, filaVecina, columnaVecina, posicion);
                }
            }
            return contadorCelulasVivas;
        }
        private void GetEstadoCelulaMuerta(int contadorCelulasVivas, Tablero tablero2, Posicion posicion)
        {
            if (contadorCelulasVivas == 3)
            {
                tablero2.TableroCelulas[posicion.Fila, posicion.Columna].TieneVida = true;
            }
            else
            {
                tablero2.TableroCelulas[posicion.Fila, posicion.Columna].TieneVida = false;
            }
        }
        private static void GetEstadoCelulaViva(int contadorCelulasVivas, Tablero tablero2, Posicion posicion)
        {
            if (contadorCelulasVivas < 2)
            {
                tablero2.TableroCelulas[posicion.Fila, posicion.Columna].TieneVida = false;
            }
            else if (contadorCelulasVivas > 3)
            {
                tablero2.TableroCelulas[posicion.Fila, posicion.Columna].TieneVida = false;
            }
            else
            {
                tablero2.TableroCelulas[posicion.Fila, posicion.Columna].TieneVida = true;
            }
        }
        private static int GetContadorCelulasVivas(Tablero tablero1, int contadorCelulasVivas, int filaVecina, int columnaVecina, Posicion posicion)
        {
            if (tablero1.TableroCelulas[filaVecina, columnaVecina].TieneVida && tablero1.TableroCelulas[filaVecina, columnaVecina] != tablero1.TableroCelulas[posicion.Fila, posicion.Columna])
            {
                contadorCelulasVivas++;
            }
            return contadorCelulasVivas;
        }
    }
}
